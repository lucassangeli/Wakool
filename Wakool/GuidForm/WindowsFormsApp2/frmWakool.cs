using ExceptionControl;
using DataAnotation.Atributi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entity;
using MetadataDiscover;
using System.ComponentModel.DataAnnotations;
using MetadataDiscover;
using ExcelCreator;
using System.Collections;
using PDFCreator;
using CustomDataAnnotations;

namespace WinFormsApp
{
    public partial class frmWakool : Form
    {
        List<Type> menuList = new List<Type>();
        Type currentType = null;
        object currentObject = null;
        int count = 4;
        List<object> itemList;

        public frmWakool()
        {
            InitializeComponent();
            lbLista.Visible = false;
            lbTitulo.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private object SetClass()
        {
            object obj = Activator.CreateInstance(currentType);
            foreach (PropertyInfo property in currentType.GetProperties())
            {

                foreach (Control item in panelEdit.Controls[0].Controls)
                {
                    if (item.Name.ToUpper().Equals(property.Name.ToUpper()))
                    {
                        if (item is MaskedTextBox)
                        {
                            property.SetValue(obj, (((MaskedTextBox)item)).Text);
                        }
                        else if (item is NumericUpDown && (item.Name.ToUpper() == property.Name.ToUpper()))
                        {
                            if (property.PropertyType == typeof(int))
                                property.SetValue(obj, (int)(((NumericUpDown)item)).Value);
                            else if (property.PropertyType == typeof(double))
                                property.SetValue(obj, (double)(((NumericUpDown)item)).Value);
                            else
                                if (property.PropertyType == typeof(decimal))
                                property.SetValue(obj, (decimal)(((NumericUpDown)item)).Value);


                        }
                        else if (item is DateTimePicker && item.Name.ToUpper() == property.Name.ToUpper())
                        {
                            property.SetValue(obj, (((DateTimePicker)item)).Value);
                        }
                        else if (item is CheckBox && item.Name.ToUpper() == property.Name.ToUpper())
                        {
                            property.SetValue(obj, (((CheckBox)item)).Checked);

                        }
                        else if (item is ComboBox && item.Name.ToUpper() == property.Name.ToUpper() && property.PropertyType.IsEnum)
                        {
                            property.SetValue(obj, (((ComboBox)item)).SelectedIndex);

                        }
                    }
                }
            }
            obj = this.IsRegularExpression(obj);
            obj = this.IsRequired(obj);
            return obj;
        }

        private object IsRegularExpression(object obj)
        {
            string error = string.Empty;
            if (obj != null)
                foreach (PropertyInfo item in obj.GetType().GetProperties())
                    if (!item.GetRegularExpression(out error, obj))
                    {
                        obj = null;
                        MessageBox.Show(error);
                    }
            return obj;
        }

        private object IsRequired(object obj)
        {
            string error = string.Empty;
            if (obj != null)
                foreach (PropertyInfo item in obj.GetType().GetProperties())
                    if (!item.GetRequired(out error, obj))
                    {
                        obj = null;
                        MessageBox.Show(error);
                    }
            return obj;
        }


        private void frmWakool_Load(object sender, EventArgs e)
        {
            try
            {
                menuList.AddRange(AssemblyUtils.GetEntities());
                CreatorMenu();
                Thread sampleThread = new Thread(delegate ()
                {
                    this.statusStrip1.Invoke(new MethodInvoker(delegate ()
                    {
                        timer1.Start();
                    }));
                });
                sampleThread.Start();
                FillGrid(dtgMotar);
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        public void CreatorMenu()
        {
            try
            {
                TableLayoutPanel tablePanel = new TableLayoutPanel();
                tablePanel.Dock = DockStyle.Fill;
                panelMenu.Controls.Add(tablePanel);
                selectType();

                int count = 0;
                foreach (Type item in menuList)
                {
                    string text = "";
                    var title = item.GetCustomAttribute<DisplayNameAttribute>();
                    if (title == null)
                        text = item.Name;
                    else
                        text = title.DisplayName;
                    Label menuItem = new Label();
                    menuItem.Font = new Font("Arial Narrow", 13.0f);
                    menuItem.ForeColor = Color.FromArgb(255, 128, 0);
                    menuItem.Text = "• " + text;
                    menuItem.Click += ClickItemMenu;
                    menuItem.Width = text.Length * 50;
                    tablePanel.Controls.Add(menuItem, 1, count);
                    count++;
                }
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        private void ClickItemMenu(object sender, EventArgs e)
        {
            try
            {
                currentType = null;
                Label tempLabel = (Label)sender;
                foreach (Type item in menuList)
                {
                    lbLista.Text = string.Empty;
                    lbTitulo.Text = string.Empty;
                    var temp = item.GetCustomAttribute<DisplayNameAttribute>();
                    if (temp != null)
                    {
                        lbLista.Text = "Listagem de ";
                        lbTitulo.Text = "Cadastro de ";
                        if (("• " + temp.DisplayName).ToString().ToUpper().Equals(tempLabel.Text.ToUpper()))
                        {
                            EditCreator(panelEdit, item);
                            currentType = item;
                            lbLista.Text += temp.DisplayName;
                            lbTitulo.Text += temp.DisplayName;
                            currentObject = Activator.CreateInstance(currentType);
                            FillGrid(dtgMotar);
                            break;
                        }
                    }
                    else
                        if (("• " + item.Name.ToUpper()).ToString().Equals(tempLabel.Text.ToUpper()))
                    {
                        lbLista.Text += item.Name;
                        lbTitulo.Text += item.Name;
                        EditCreator(panelEdit, item);
                        currentType = item;
                        currentObject = Activator.CreateInstance(currentType);
                        
                        FillGrid(dtgMotar);
                        currentType = item;
                        break;
                    }
                }
                lbLista.Visible = true;
                lbTitulo.Visible = true;
                splitContainer1.Visible = true;
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
                MessageBox.Show("Erro ao criar tela:" + ex.Message);
            }
        }

        public void selectType()
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();

                foreach (Type item in assembly.GetTypes())
                {
                    var temp = item.GetCustomAttribute<CustomVisibleAttribute>();
                    if (temp != null && temp.visivel)
                    {
                        menuList.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        public void panelTitle(Type type)
        {
            try
            {
                string title = string.Empty;
                var temp = type.GetCustomAttribute<Title>();
                if (temp != null)
                {
                    title = temp.text;
                }
                else
                {
                    title = type.Name;
                }
                lbTitulo.Text += title;
                lbLista.Text += title;
                this.Text = "Tela de " + title + "s";
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        PropertyInfo hasProperty = null;
        List<Tuple<MaskedTextBox, PropertyInfo>> MaskedTextBoxLengt = new List<Tuple<MaskedTextBox, PropertyInfo>>();

        public void EditCreator(Panel editPanel, Type type)
        {
            try
            {
                editPanel.Controls.Clear();
                TableLayoutPanel panel = new TableLayoutPanel();
                panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                panel.AutoSize = true;
                panel.Dock = DockStyle.Fill;
                Color color = Color.Orange;
                editPanel.Controls.Add(panel);
                this.WindowState = FormWindowState.Maximized;

                foreach (PropertyInfo property in type.GetProperties())
                {
                    hasProperty = null;
                    string text = "";
                    DisplayNameAttribute titulo = property.GetCustomAttribute<DisplayNameAttribute>();
                    if (titulo == null)
                        text = property.Name;
                    else
                        text = titulo.DisplayName;

                    if (property.Name.ToUpper() != "ID" && property.PropertyType != typeof(bool))
                    {
                        Label label = new Label();
                        label.Width = text.Length * 15;
                        label.Text = text;
                        label.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold);
                        if (property.PropertyType == typeof(string))
                        {
                            string error = string.Empty;
                            MaskedTextBox masked = new MaskedTextBox();
                            masked.Name = property.Name;
                            if (property.GetMaxStringLength(out error) > 0)
                            {
                                MaskedTextBoxLengt.Add(new Tuple<MaskedTextBox, PropertyInfo>(masked, property));
                                masked.Leave += mtxt_Leave;
                            }
                            if (property.GetCustomAttribute<MaskedTextAttribute>() != null)
                            {
                                masked.Mask = property.GetCustomAttribute<MaskedTextAttribute>().Mask;
                                masked.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                            }

                            masked.Tag = text;
                            masked.Font = new Font("Segoe UI", 12.0f);
                            masked.BorderStyle = BorderStyle.None;
                            masked.ForeColor = Color.White;
                            masked.BackColor = color;
                            masked.Width = 200;
                            panel.Controls.Add(label, 0, count);
                            panel.Controls.Add(masked, 1, count);
                        }
                        else if (property.PropertyType == typeof(int) || property.PropertyType == typeof(double) || property.PropertyType == typeof(decimal))
                        {
                            NumericUpDown numeric = new NumericUpDown();
                            numeric.Width = 130;
                            if (property.PropertyType == typeof(double) || property.PropertyType == typeof(decimal))
                            {
                                numeric.DecimalPlaces = 2;
                                numeric.Increment = 0.1M;
                            }
                            numeric.Tag = text;
                            numeric.Name = property.Name;
                            numeric.ForeColor = Color.White;
                            numeric.BackColor = color;
                            numeric.Width = 200;
                            panel.Controls.Add(label, 0, count);
                            panel.Controls.Add(numeric, 1, count);
                        }
                        else if (property.PropertyType == typeof(DateTime))
                        {
                            DateTimePicker picker = new DateTimePicker();
                            picker.Value = DateTime.Now;
                            picker.Tag = text;
                            picker.Name = property.Name;
                            picker.Format = DateTimePickerFormat.Custom;
                            picker.CustomFormat = "dd/MM/yyyy";
                            picker.Width = 200;
                            panel.Controls.Add(label, 0, count);
                            panel.Controls.Add(picker, 1, count);
                        }
                        else
                            if (property.PropertyType.IsEnum)
                        {
                            ComboBox combo = new ComboBox();
                            combo.Width = 200;
                            combo.Name = property.Name;
                            combo.DataSource = Enum.GetValues(property.PropertyType);
                            combo.DropDownStyle = ComboBoxStyle.DropDownList;
                            panel.Controls.Add(label, 0, count);
                            panel.Controls.Add(combo, 1, count);
                        }
                        count++;
                    }
                    else
                        if (property.PropertyType == typeof(bool))
                    {
                        CheckBox check = new CheckBox();
                        check.Name = property.Name;
                        check.Font = new Font("Segoe UI", 12.0f, FontStyle.Bold);
                        check.Text = text;
                        check.Width = text.Length * 20;
                        check.Tag = text;
                        panel.Controls.Add(check, 1, count);
                        count++;
                    }
                    else
                            if (property.Name.ToUpper() == "ID")
                    {
                        NumericUpDown numeric = new NumericUpDown();
                        numeric.Visible = false;
                        numeric.Name = property.Name;
                        panel.Controls.Add(numeric, 1, count);
                        count++;
                    }
                }
                editPanel.AutoScrollMinSize = new Size(0, (panel.Controls.Count * 50));
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        void mtxt_Leave(object sender, EventArgs e)
        {
            try
            {
                string message = string.Empty;
                int i = ((MaskedTextBox)sender).Text.Length;
                PropertyInfo[] item = currentType.GetProperties().Where(x => x.Name == ((MaskedTextBox)sender).Name).ToArray();
                if (item.Count() > 0)
                {

                    if (i < item[0].GetMinStringLength(out message) || i > item[0].GetMaxStringLength(out message))
                        MessageBox.Show(message);
                }
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        void limpTela_Click(object sender, EventArgs e)
        {
            try
            {
                EditCreator(panelEdit, currentType);
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        void delet_Click(object sender, EventArgs e)
        {
            try
            {
                if (SetClass() != null && ((EntityBase)SetClass()).ID > 0)
                {
                    new BusinessLogicalLayer.EntityBLL().Delete(((EntityBase)SetClass()), currentType);
                    FillGrid(dtgMotar);
                    MessageBox.Show("Registro excluído com sucesso.");
                }
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        public void sav_Click(object sender, EventArgs e)
        {
            try
            {
                new BusinessLogicalLayer.EntityBLL().Insert(((EntityBase)SetClass()));
                FillGrid(dtgMotar);
                if (((EntityBase)SetClass()).ID == 0)
                    MessageBox.Show("Registro cadastrado com sucesso.");
                else
                    MessageBox.Show("Registro alterado com sucesso.");
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        public void FillGrid(DataGridView gridView)
        {
            try
            {
                gridView.DataSource = null;
                if (currentType != null)
                {
                    itemList = new BusinessLogicalLayer.EntityBLL().GetAll((EntityBase)currentObject, currentType);
                    dtgMotar.Rows.Clear();
                    dtgMotar.DataSource = itemList;

                    if (currentType != null)
                        foreach (DataGridViewColumn item in gridView.Columns)
                        {
                            foreach (PropertyInfo itemProperty in currentType.BaseType.GetProperties())
                            {
                                if (item.DataPropertyName == itemProperty.Name)
                                    item.HeaderText = AssemblyUtils.GetPropertyDisplay(itemProperty);
                            }
                        }
                }
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString();
        }

        private void pnlCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlMinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dtgMotar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = ((DataGridView)(sender)).CurrentRow;
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    foreach (Control item in panelEdit.Controls)
                        if (item.Controls != null)
                            foreach (Control itemControls in item.Controls)
                            {
                                if (!(itemControls is Label) && item.Name.ToUpper() != "ID")
                                {
                                    if (row.Cells[i].OwningColumn.Name.ToString().Trim().ToUpper().Equals(itemControls.Name.ToUpper().Trim()))
                                    {
                                        if (itemControls is TextBox)
                                        {
                                            ((TextBox)(itemControls)).Text = ((row.Cells[i].Value != null) ? row.Cells[i].Value : "").ToString();
                                        }
                                        else
                                            if (itemControls is MaskedTextBox)
                                        {
                                            ((MaskedTextBox)(itemControls)).Text = ((row.Cells[i].Value != null) ? row.Cells[i].Value : "").ToString();
                                        }
                                        else
                                                if (itemControls is NumericUpDown)
                                        {
                                            ((NumericUpDown)(itemControls)).Value = Convert.ToDecimal(row.Cells[i].Value.ToString());
                                        }
                                        else
                                                    if (itemControls is CheckBox)
                                        {
                                            ((CheckBox)(itemControls)).Checked = Convert.ToBoolean(row.Cells[i].Value);
                                        }
                                        if (itemControls is ComboBox)
                                        {
                                            object temp = Activator.CreateInstance(row.Cells[i].ValueType);


                                            int t = Convert.ToInt32(Enum.Parse(temp.GetType(), row.Cells[i].Value.ToString()));

                                            ((ComboBox)(itemControls)).DataSource = Enum.GetValues(temp.GetType());

                                            ((ComboBox)(itemControls)).SelectedIndex = t;
                                        }
                                        else
                                            if (itemControls is DateTimePicker)
                                        {
                                            DateTime date = new DateTime();
                                            if (!DateTime.TryParse((row.Cells[i].Value.ToString()), out date))
                                                ((DateTimePicker)(itemControls)).Value = Convert.ToDateTime(row.Cells[i].Value.ToString());
                                            else
                                                ((DateTimePicker)(itemControls)).Value = DateTime.Now;
                                        }
                                    }
                                    else
                                        if (itemControls is NumericUpDown)
                                    {
                                        ((NumericUpDown)(itemControls)).Value = Convert.ToInt32(row.Cells["ID"].Value.ToString());
                                    }
                                }
                            }
                }
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    StringBuilder builder = new StringBuilder();
                    string name = "ArchiveExcel" + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss").Replace(" ", "").Replace("/", "").Replace(":", "");
                    save.FileName = name;
                    save.Filter = "Excel Files | *.xls";
                    save.DefaultExt = "xls";

                    DialogResult result = save.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        ExcelCreator.ExcelCreation.ListToExcel(itemList, save.FileName, currentType);
                        MessageBox.Show(string.Format(@"O arquivo foi criado na pasta {0} .", save.FileName));
                    }
                }
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    StringBuilder builder = new StringBuilder();
                    string name = "ArchivePDF" + DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss").Replace(" ", "").Replace("/", "").Replace(":", "");
                    save.FileName = name;
                    save.Filter = "PDF Files | *.PDF";
                    save.DefaultExt = "pdf";

                    DialogResult result = save.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        PDFCreator.PDFCreation.BuildPDF(itemList, save.FileName, currentType);
                        MessageBox.Show(string.Format(@"O arquivo foi criado na pasta {0} .", save.FileName));
                    }
                }
            }
            catch (Exception ex)
            {
                new ExceptionControl.LogConfing.ExceptionText(ex);
            }
        }
    }
}

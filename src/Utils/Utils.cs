using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Management;
using ComponentFactory.Krypton.Toolkit;
using System.Globalization;
using CashInBox.Extensions;
using CashInBox.Enums;

namespace CashInBox
{
    public class Utils
    {
        public static void LimparCampos(Form f)
        {

            foreach (Control c in f.Controls)
            {
                try
                {
                    if (c is DateTimePicker)
                    {
                        ((DateTimePicker)(c)).Value = DateTime.Now; ;
                    }
                    if (c is TextBox)
                    {
                        ((TextBox)(c)).Clear();
                    }
                    if (c is MaskedTextBox)
                    {
                        ((MaskedTextBox)(c)).Clear();
                    }
                    if (c is DataGridView)
                    {
                        ((DataGridView)(c)).Rows.Clear();
                    }
                    if (c is ComboBox)
                    {
                        ((ComboBox)(c)).SelectedIndex = -1;
                    }
                    if (c is RadioButton)
                    {
                        ((RadioButton)(c)).Checked = false;
                    }
                    if (c is CheckBox)
                    {
                        ((CheckBox)(c)).Checked = false;
                    }
                    if (c is GroupBox)
                    {
                        foreach (Control x in ((GroupBox)(c)).Controls)
                        {
                            if (x is TextBox)
                            {
                                ((TextBox)(x)).Clear();
                            }
                            if (x is MaskedTextBox)
                            {
                                ((MaskedTextBox)(x)).Clear();
                            }
                            if (x is ComboBox)
                            {
                                ((ComboBox)(x)).SelectedIndex = -1;
                            }
                            if (x is RadioButton)
                            {
                                ((RadioButton)(x)).Checked = false;
                            }
                            if (x is DataGridView)
                            {
                                ((DataGridView)(x)).Rows.Clear();
                            }
                            if (x is CheckBox)
                            {
                                ((CheckBox)(x)).Checked = false;
                            }
                        }
                    }
                    if (c is TabControl)
                    {
                        foreach (Control x in ((TabControl)(c)).Controls)
                        {
                            if (x is TabPage)
                            {
                                foreach (Control y in ((TabPage)(x)).Controls)
                                {
                                    if (y is DateTimePicker)
                                    {
                                        ((DateTimePicker)(y)).Value = DateTime.Now; ;
                                    }
                                    if (y is TextBox)
                                    {
                                        ((TextBox)(y)).Clear();
                                    }
                                    if (y is MaskedTextBox)
                                    {
                                        ((MaskedTextBox)(y)).Clear();
                                    }
                                    if (y is DataGridView)
                                    {
                                        ((DataGridView)(y)).Rows.Clear();
                                    }
                                    if (y is ComboBox)
                                    {
                                        ((ComboBox)(y)).SelectedIndex = -1;
                                    }
                                    if (y is RadioButton)
                                    {
                                        ((RadioButton)(y)).Checked = false;
                                    }
                                    if (y is GroupBox)
                                    {
                                        foreach (Control p in ((GroupBox)(y)).Controls)
                                        {
                                            if (p is TextBox)
                                            {
                                                ((TextBox)(p)).Clear();
                                            }
                                            if (p is MaskedTextBox)
                                            {
                                                ((MaskedTextBox)(p)).Clear();
                                            }
                                            if (p is ComboBox)
                                            {
                                                ((ComboBox)(p)).SelectedIndex = -1;
                                            }
                                            if (p is RadioButton)
                                            {
                                                ((RadioButton)(p)).Checked = false;
                                            }
                                            if (p is DataGridView)
                                            {
                                                ((DataGridView)(p)).Rows.Clear();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (c is Panel)
                    {
                        foreach (Control x in ((Panel)(c)).Controls)
                        {

                            if (x is DateTimePicker)
                            {
                                ((DateTimePicker)(x)).Value = DateTime.Now; ;
                            }
                            if (x is TextBox)
                            {
                                ((TextBox)(x)).Clear();
                            }
                            if (x is MaskedTextBox)
                            {
                                ((MaskedTextBox)(x)).Clear();
                            }
                            if (x is DataGridView)
                            {
                                ((DataGridView)(x)).Rows.Clear();
                            }
                            if (x is ComboBox)
                            {
                                ((ComboBox)(x)).SelectedIndex = -1;
                            }
                            if (x is RadioButton)
                            {
                                ((RadioButton)(x)).Checked = false;
                            }
                            if (x is GroupBox)
                            {
                                foreach (Control y in ((GroupBox)(x)).Controls)
                                {
                                    if (y is TextBox)
                                    {
                                        ((TextBox)(y)).Clear();
                                    }
                                    if (y is MaskedTextBox)
                                    {
                                        ((MaskedTextBox)(y)).Clear();
                                    }
                                    if (y is ComboBox)
                                    {
                                        ((ComboBox)(y)).SelectedIndex = -1;
                                    }
                                    if (y is RadioButton)
                                    {
                                        ((RadioButton)(y)).Checked = false;
                                    }
                                    if (y is DataGridView)
                                    {
                                        ((DataGridView)(y)).Rows.Clear();
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                }
            }
        }

        public static void FocusInTextMask(object txtBox)
        {
            try
            {
                //faz o cast do tipo object para o tipo TextBox
                TextBox t = txtBox as TextBox;
                t.BackColor = Color.FromArgb(255,246,148);
            }
            catch
            {
                //faz o cast do tipo object para o tipo MaskedTextBox
                MaskedTextBox m = txtBox as MaskedTextBox;
                m.BackColor = Color.FromArgb(255, 246, 148);
            }
        }

        public static void FocusOutRichText(object richtxtBox)
        {
            //faz o cast do tipo object para o tipo RichTextBox
            RichTextBox t = richtxtBox as RichTextBox;
            t.BackColor = SystemColors.Window;
        }

        public static void FocusOutTextMask(object txtBox)
        {
            try
            {
                //faz o cast do tipo object para o tipo TextBox
                TextBox t = txtBox as TextBox;
                t.BackColor = Color.White;

            }
            catch
            {
                //faz o cast do tipo object para o tipo MaskedTextBox
                MaskedTextBox m = txtBox as MaskedTextBox;
                m.BackColor = Color.White;
            }
        }

        public static void FocusInCombo(object combo)
        {
            //faz o cast do tipo object para o tipo TextBox
            ComboBox c = combo as ComboBox;
            c.BackColor = Color.FromArgb(255, 246, 148);
        }

        public static void FocusOutCombo(object combo)
        {
            //faz o cast do tipo object para o tipo TextBox
            ComboBox c = combo as ComboBox;
            c.BackColor = Color.White;
        }

        public static void Desabilitar(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is CheckedListBox)
                {
                    ((CheckedListBox)(c)).Enabled = false;
                }
                if (c is RichTextBox)
                {
                    ((RichTextBox)(c)).Enabled = false;
                }
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)(c)).Enabled = false;
                }
                if (c is Button)
                {
                    ((Button)(c)).Enabled = false;
                }
                if (c is KryptonButton)
                {
                    ((KryptonButton)(c)).Enabled = false;
                }
                if (c is TextBox)
                {
                    ((TextBox)(c)).Enabled = false;
                }
                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)(c)).Enabled = false;
                }
                if (c is DataGridView)
                {
                    ((DataGridView)(c)).Enabled = false;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)(c)).Enabled = false;
                }
                if (c is RadioButton)
                {
                    ((RadioButton)(c)).Enabled = false;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)(c)).Enabled = false;
                }
                if (c is TreeView)
                {
                    ((TreeView)c).Enabled = false;
                    ((TreeView)c).BackColor = SystemColors.ControlLight;
                }
                if (c is GroupBox)
                {
                    foreach (Control x in ((GroupBox)(c)).Controls)
                    {
                        if (x is DateTimePicker)
                        {
                            ((DateTimePicker)(x)).Enabled = false;
                        }
                        if (x is TextBox)
                        {
                            ((TextBox)(x)).Enabled = false;
                        }
                        if (x is MaskedTextBox)
                        {
                            ((MaskedTextBox)(x)).Enabled = false;
                        }
                        if (x is ComboBox)
                        {
                            ((ComboBox)(x)).Enabled = false;
                        }
                        if (x is RadioButton)
                        {
                            ((RadioButton)(x)).Enabled = false;
                        }
                        if (x is Button)
                        {
                            ((Button)(x)).Enabled = false;
                        }
                        if (x is KryptonButton)
                        {
                            ((KryptonButton)(x)).Enabled = false;
                        }
                        if (x is DataGridView)
                        {
                            ((DataGridView)(x)).Enabled = false;
                        }
                        if (x is CheckBox)
                        {
                            ((CheckBox)(x)).Enabled = false;
                        }
                    }
                }
                if (c is TabControl)
                {
                    foreach (Control x in ((TabControl)(c)).Controls)
                    {
                        if (x is TabPage)
                        {
                            foreach (Control y in ((TabPage)(x)).Controls)
                            {
                                if (y is CheckedListBox)
                                {
                                    ((CheckedListBox)(y)).Enabled = false;
                                }
                                if (y is RichTextBox)
                                {
                                    ((RichTextBox)(y)).Enabled = false;
                                }
                                if (y is DateTimePicker)
                                {
                                    ((DateTimePicker)(y)).Enabled = false;
                                }
                                if (y is Button)
                                {
                                    ((Button)(y)).Enabled = false;
                                }
                                if (y is KryptonButton)
                                {
                                    ((KryptonButton)(y)).Enabled = false;
                                }
                                if (y is TextBox)
                                {
                                    ((TextBox)(y)).Enabled = false;
                                }
                                if (y is MaskedTextBox)
                                {
                                    ((MaskedTextBox)(y)).Enabled = false;
                                }
                                if (y is DataGridView)
                                {
                                    ((DataGridView)(y)).Enabled = false;
                                }
                                if (y is ComboBox)
                                {
                                    ((ComboBox)(y)).Enabled = false;
                                }
                                if (y is RadioButton)
                                {
                                    ((RadioButton)(y)).Enabled = false;
                                }
                                if (y is TreeView)
                                {
                                    ((TreeView)y).Enabled = false;
                                    ((TreeView)y).BackColor = SystemColors.ControlLight;
                                }
                                if (y is GroupBox)
                                {
                                    foreach (Control p in ((GroupBox)(y)).Controls)
                                    {
                                        if (p is DateTimePicker)
                                        {
                                            ((DateTimePicker)(p)).Enabled = false;
                                        }
                                        if (p is TextBox)
                                        {
                                            ((TextBox)(p)).Enabled = false;
                                        }
                                        if (p is MaskedTextBox)
                                        {
                                            ((MaskedTextBox)(p)).Enabled = false;
                                        }
                                        if (p is ComboBox)
                                        {
                                            ((ComboBox)(p)).Enabled = false;
                                        }
                                        if (p is RadioButton)
                                        {
                                            ((RadioButton)(p)).Enabled = false;
                                        }
                                        if (p is Button)
                                        {
                                            ((Button)(p)).Enabled = false;
                                        }
                                        if (p is KryptonButton)
                                        {
                                            ((KryptonButton)(p)).Enabled = false;
                                        }
                                        if (p is DataGridView)
                                        {
                                            ((DataGridView)(p)).Enabled = false;
                                        }
                                        if (p is CheckBox)
                                        {
                                            ((CheckBox)(p)).Enabled = false;
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                if (c is Panel)
                {
                    foreach (Control x in ((Panel)(c)).Controls)
                    {

                        if (x is CheckedListBox)
                        {
                            ((CheckedListBox)(x)).Enabled = false;
                        }
                        if (x is RichTextBox)
                        {
                            ((RichTextBox)(x)).Enabled = false;
                        }
                        if (x is DateTimePicker)
                        {
                            ((DateTimePicker)(x)).Enabled = false;
                        }
                        if (x is Button)
                        {
                            ((Button)(x)).Enabled = false;
                        }
                        if (x is KryptonButton)
                        {
                            ((KryptonButton)(x)).Enabled = false;
                        }
                        if (x is TextBox)
                        {
                            ((TextBox)(x)).Enabled = false;
                        }
                        if (x is MaskedTextBox)
                        {
                            ((MaskedTextBox)(x)).Enabled = false;
                        }
                        if (x is DataGridView)
                        {
                            ((DataGridView)(x)).Enabled = false;
                        }
                        if (x is ComboBox)
                        {
                            ((ComboBox)(x)).Enabled = false;
                        }
                        if (x is RadioButton)
                        {
                            ((RadioButton)(x)).Enabled = false;
                        }
                        if (x is TreeView)
                        {
                            ((TreeView)x).Enabled = false;
                            ((TreeView)x).BackColor = SystemColors.ControlLight;
                        }
                        if (x is GroupBox)
                        {
                            foreach (Control p in ((GroupBox)(x)).Controls)
                            {
                                if (p is DateTimePicker)
                                {
                                    ((DateTimePicker)(p)).Enabled = false;
                                }
                                if (p is TextBox)
                                {
                                    ((TextBox)(p)).Enabled = false;
                                }
                                if (p is MaskedTextBox)
                                {
                                    ((MaskedTextBox)(p)).Enabled = false;
                                }
                                if (p is ComboBox)
                                {
                                    ((ComboBox)(p)).Enabled = false;
                                }
                                if (p is RadioButton)
                                {
                                    ((RadioButton)(p)).Enabled = false;
                                }
                                if (p is Button)
                                {
                                    ((Button)(p)).Enabled = false;
                                }
                                if (p is KryptonButton)
                                {
                                    ((KryptonButton)(p)).Enabled = false;
                                }
                                if (p is DataGridView)
                                {
                                    ((DataGridView)(p)).Enabled = false;
                                }
                            }
                        }
                    }
                }

            }
        }

        public static void Habilitar(Form f)
        {
            foreach (Control c in f.Controls)
            {
                if (c is CheckedListBox)
                {
                    ((CheckedListBox)(c)).Enabled = true;
                }
                if (c is RichTextBox)
                {
                    ((RichTextBox)(c)).Enabled = true;
                }
                if (c is DateTimePicker)
                {
                    ((DateTimePicker)(c)).Enabled = true;
                }
                if (c is Button)
                {
                    ((Button)(c)).Enabled = true;
                }
                if (c is KryptonButton)
                {
                    ((KryptonButton)(c)).Enabled = true;
                }
                if (c is TextBox)
                {
                    ((TextBox)(c)).Enabled = true;
                }
                if (c is MaskedTextBox)
                {
                    ((MaskedTextBox)(c)).Enabled = true;
                }
                if (c is DataGridView)
                {
                    ((DataGridView)(c)).Enabled = true;
                }
                if (c is ComboBox)
                {
                    ((ComboBox)(c)).Enabled = true;
                }
                if (c is RadioButton)
                {
                    ((RadioButton)(c)).Enabled = true;
                }
                if (c is CheckBox)
                {
                    ((CheckBox)(c)).Enabled = true;
                }
                if (c is TreeView)
                {
                    ((TreeView)c).Enabled = true;
                    ((TreeView)c).BackColor = SystemColors.Window;
                }
                if (c is GroupBox)
                {
                    foreach (Control x in ((GroupBox)(c)).Controls)
                    {
                        if (x is DateTimePicker)
                        {
                            ((DateTimePicker)(x)).Enabled = true;
                        }
                        if (x is TextBox)
                        {
                            ((TextBox)(x)).Enabled = true;
                        }
                        if (x is MaskedTextBox)
                        {
                            ((MaskedTextBox)(x)).Enabled = true;
                        }
                        if (x is ComboBox)
                        {
                            ((ComboBox)(x)).Enabled = true;
                        }
                        if (x is RadioButton)
                        {
                            ((RadioButton)(x)).Enabled = true;
                        }
                        if (x is Button)
                        {
                            ((Button)(x)).Enabled = true;
                        }
                        if (x is KryptonButton)
                        {
                            ((KryptonButton)(x)).Enabled = true;
                        }
                        if (x is DataGridView)
                        {
                            ((DataGridView)(x)).Enabled = true;
                        }
                        if (x is CheckBox)
                        {
                            ((CheckBox)(x)).Enabled = true;
                        }
                    }
                }
                if (c is TabControl)
                {
                    foreach (Control x in ((TabControl)(c)).Controls)
                    {
                        if (x is TabPage)
                        {
                            foreach (Control y in ((TabPage)(x)).Controls)
                            {
                                if (y is CheckedListBox)
                                {
                                    ((CheckedListBox)(y)).Enabled = true;
                                }
                                if (y is RichTextBox)
                                {
                                    ((RichTextBox)(y)).Enabled = true;
                                }
                                if (y is DateTimePicker)
                                {
                                    ((DateTimePicker)(y)).Enabled = true;
                                }
                                if (y is Button)
                                {
                                    ((Button)(y)).Enabled = true;
                                }
                                if (y is KryptonButton)
                                {
                                    ((KryptonButton)(y)).Enabled = true;
                                }
                                if (y is TextBox)
                                {
                                    ((TextBox)(y)).Enabled = true;
                                }
                                if (y is MaskedTextBox)
                                {
                                    ((MaskedTextBox)(y)).Enabled = true;
                                }
                                if (y is DataGridView)
                                {
                                    ((DataGridView)(y)).Enabled = true;
                                }
                                if (y is ComboBox)
                                {
                                    ((ComboBox)(y)).Enabled = true;
                                }
                                if (y is RadioButton)
                                {
                                    ((RadioButton)(y)).Enabled = true;
                                }
                                if (y is TreeView)
                                {
                                    ((TreeView)y).Enabled = true;
                                    ((TreeView)y).BackColor = SystemColors.ControlLight;
                                }
                                if (y is GroupBox)
                                {
                                    foreach (Control p in ((GroupBox)(y)).Controls)
                                    {
                                        if (p is DateTimePicker)
                                        {
                                            ((DateTimePicker)(p)).Enabled = true;
                                        }
                                        if (p is TextBox)
                                        {
                                            ((TextBox)(p)).Enabled = true;
                                        }
                                        if (p is MaskedTextBox)
                                        {
                                            ((MaskedTextBox)(p)).Enabled = true;
                                        }
                                        if (p is ComboBox)
                                        {
                                            ((ComboBox)(p)).Enabled = true;
                                        }
                                        if (p is RadioButton)
                                        {
                                            ((RadioButton)(p)).Enabled = true;
                                        }
                                        if (p is Button)
                                        {
                                            ((Button)(p)).Enabled = true;
                                        }
                                        if (p is KryptonButton)
                                        {
                                            ((KryptonButton)(p)).Enabled = true;
                                        }
                                        if (p is DataGridView)
                                        {
                                            ((DataGridView)(p)).Enabled = true;
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                if (c is Panel)
                {
                    foreach (Control x in ((Panel)(c)).Controls)
                    {
                        if (x is CheckedListBox)
                        {
                            ((CheckedListBox)(x)).Enabled = true;
                        }
                        if (x is RichTextBox)
                        {
                            ((RichTextBox)(x)).Enabled = true;
                        }
                        if (x is DateTimePicker)
                        {
                            ((DateTimePicker)(x)).Enabled = true;
                        }
                        if (x is Button)
                        {
                            ((Button)(x)).Enabled = true;
                        }
                        if (x is KryptonButton)
                        {
                            ((KryptonButton)(x)).Enabled = true;
                        }
                        if (x is TextBox)
                        {
                            ((TextBox)(x)).Enabled = true;
                        }
                        if (x is MaskedTextBox)
                        {
                            ((MaskedTextBox)(x)).Enabled = true;
                        }
                        if (x is DataGridView)
                        {
                            ((DataGridView)(x)).Enabled = true;
                        }
                        if (x is ComboBox)
                        {
                            ((ComboBox)(x)).Enabled = true;
                        }
                        if (x is RadioButton)
                        {
                            ((RadioButton)(x)).Enabled = true;
                        }
                        if (x is TreeView)
                        {
                            ((TreeView)x).Enabled = true;
                            ((TreeView)x).BackColor = SystemColors.ControlLight;
                        }
                        if (x is GroupBox)
                        {
                            foreach (Control p in ((GroupBox)(x)).Controls)
                            {
                                if (p is DateTimePicker)
                                {
                                    ((DateTimePicker)(p)).Enabled = true;
                                }
                                if (p is TextBox)
                                {
                                    ((TextBox)(p)).Enabled = true;
                                }
                                if (p is MaskedTextBox)
                                {
                                    ((MaskedTextBox)(p)).Enabled = true;
                                }
                                if (p is ComboBox)
                                {
                                    ((ComboBox)(p)).Enabled = true;
                                }
                                if (p is RadioButton)
                                {
                                    ((RadioButton)(p)).Enabled = true;
                                }
                                if (p is Button)
                                {
                                    ((Button)(p)).Enabled = true;
                                }
                                if (p is KryptonButton)
                                {
                                    ((KryptonButton)(p)).Enabled = true;
                                }
                                if (p is DataGridView)
                                {
                                    ((DataGridView)(p)).Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        public static void PonteiroInicialMascara(object mask)
        {
            //faz o cast do tipo object para o tipo MaskedTextBox
            MaskedTextBox m = mask as MaskedTextBox;
            m.SelectionLength = 0;
            m.SelectionStart = 0;
        }

        public static bool ConverterParaInt(object textbox)
        {
            int i = 0;
            TextBox t = textbox as TextBox;

            try
            {
                i = int.Parse(t.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool ConverterParaFloat(object textbox)
        {
            float i = 0;
            TextBox t = textbox as TextBox;

            try
            {
                i = float.Parse(t.Text);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool PressionarEnterCampoTexto(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void TrocarCorFundoBotao(object botao, Color cor)
        {
            Button b = botao as Button;
            b.BackColor = cor;
        }

        public static void InformarConsultaVazia(object dataGridView)
        {
            DataGridView data = dataGridView as DataGridView;

            if (data.Rows.Count < 1)
            {
                Mensagens.mensagemALERTA("Não foi encontrado nenhum registro com o valor informado ou não há nenhum registro cadastrado.");
            }
        }        

        public static string adicionarZerosEsquerda(int valor, int qtd)
        {
            string num = "";
            for (int i = 0; i < qtd; i++)
            {
                num += "0";
            }
            num += valor.ToString();

            return num;
        }

        public static string RemoveCaracteresEspeciais(string texto, bool aceitaEspaco, bool substituiAcentos)
        {
            string ret = texto;

            if (string.IsNullOrEmpty(ret))
                return ret;

            if (substituiAcentos)
                ret = RemoveAcentos(ret);

            if (aceitaEspaco)
                ret = System.Text.RegularExpressions.Regex.Replace(ret, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ\s]+?", string.Empty);
            else
                ret = System.Text.RegularExpressions.Regex.Replace(ret, @"[^0-9a-zA-ZéúíóáÉÚÍÓÁèùìòàÈÙÌÒÀõãñÕÃÑêûîôâÊÛÎÔÂëÿüïöäËYÜÏÖÄçÇ]+?", string.Empty);

            return ret;
        }

        public static string RemoveAcentos(string text)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
                sb.Append(s_Accents[text[i]]);

            return sb.ToString();
        }

        private static readonly char[] s_Accents = GetAccents();
        private static char[] GetAccents()
        {
            char[] accents = new char[256];

            for (int i = 0; i < 256; i++)
                accents[i] = (char)i;

            accents[(byte)'á'] = accents[(byte)'à'] = accents[(byte)'ã'] = accents[(byte)'â'] = accents[(byte)'ä'] = 'a';
            accents[(byte)'Á'] = accents[(byte)'À'] = accents[(byte)'Ã'] = accents[(byte)'Â'] = accents[(byte)'Ä'] = 'A';

            accents[(byte)'é'] = accents[(byte)'è'] = accents[(byte)'ê'] = accents[(byte)'ë'] = 'e';
            accents[(byte)'É'] = accents[(byte)'È'] = accents[(byte)'Ê'] = accents[(byte)'Ë'] = 'E';

            accents[(byte)'í'] = accents[(byte)'ì'] = accents[(byte)'î'] = accents[(byte)'ï'] = 'i';
            accents[(byte)'Í'] = accents[(byte)'Ì'] = accents[(byte)'Î'] = accents[(byte)'Ï'] = 'I';

            accents[(byte)'ó'] = accents[(byte)'ò'] = accents[(byte)'ô'] = accents[(byte)'õ'] = accents[(byte)'ö'] = 'o';
            accents[(byte)'Ó'] = accents[(byte)'Ò'] = accents[(byte)'Ô'] = accents[(byte)'Õ'] = accents[(byte)'Ö'] = 'O';

            accents[(byte)'ú'] = accents[(byte)'ù'] = accents[(byte)'û'] = accents[(byte)'ü'] = 'u';
            accents[(byte)'Ú'] = accents[(byte)'Ù'] = accents[(byte)'Û'] = accents[(byte)'Ü'] = 'U';

            accents[(byte)'ç'] = 'c';
            accents[(byte)'Ç'] = 'C';

            accents[(byte)'ñ'] = 'n';
            accents[(byte)'Ñ'] = 'N';

            accents[(byte)'ÿ'] = accents[(byte)'ý'] = 'y';
            accents[(byte)'Ý'] = 'Y';

            return accents;
        }

        public static string FormatarParaValorEmReais(float valor)
        {
            return valor.ToString("#,0.00",
                  CultureInfo.CurrentCulture);
        }        

        public static List<string> recuperarListaEstados(){

            List<string> estados = new List<string>();

            estados.Add("AC");
            estados.Add("AL");
            estados.Add("AP");
            estados.Add("AM");
            estados.Add("BA");
            estados.Add("CE");
            estados.Add("DF");
            estados.Add("ES");
            estados.Add("GO");
            estados.Add("MA");
            estados.Add("MT");
            estados.Add("MS");
            estados.Add("MG");
            estados.Add("PA");
            estados.Add("PB");
            estados.Add("PR");
            estados.Add("PE");
            estados.Add("PI");
            estados.Add("RJ");
            estados.Add("RN");
            estados.Add("RS");
            estados.Add("RO");
            estados.Add("RR");
            estados.Add("SC");
            estados.Add("SP");
            estados.Add("SE");
            estados.Add("TO");

            return estados;

       }

        public static List<string> recuperarListaTiposTel()
        {
            return Enum.GetNames(typeof(PhoneType)).ToList();           
        }

        public static List<string> recuperarListaStatus()
        {
            var listStatus = Enum.GetNames(typeof(StatusType)).ToList();
            List<string> status = new List<string>();

            foreach (var item in listStatus)
            {
                status.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.ToLower()));
            }

            return status;
        }

        public static List<string> recuperarDiasSemana()
        {
            List<string> dias = new List<string>();

            dias.Add("Segunda");
            dias.Add("Terca");
            dias.Add("Quarta");
            dias.Add("Quinta");
            dias.Add("Sexta");
            dias.Add("Sabado");
            dias.Add("Domingo");

            return dias;
        }

        public static List<string> recuperarHorarios()
        {
            var listHorarios = Enum.GetNames(typeof(HourType)).ToList();
            List<string> horarios = new List<string>();

            foreach (var item in listHorarios)
            {
                horarios.Add(EnumHelper.GetDescription(EnumHelper.ParseEnum<HourType>(item)));
            }

            return horarios;
        }

        public static List<string> recuperarMeses()
        {
            var listMeses = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList();
            List<string> meses = new List<string>();
            foreach (var item in listMeses)
            {
                meses.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.ToLower()));
            }

            return meses;
        }
        public static int NumeroMes(string mes)
        {
            int month = DateTimeFormatInfo.CurrentInfo.MonthNames.ToList().IndexOf(mes.ToLower()) + 1;            
            return month;
        }
        public static List<string> recuperarIsento()
        {
            List<string> isentos = new List<string>();
            isentos.Add("Sim");
            isentos.Add("Não");
            return isentos;
        }
    }
}

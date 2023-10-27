using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnalizadorLexicogrupo9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void ParseCPlusPlusCode(string code)
        {
            // Define patrones regex para diferentes componentes
            string keywordPattern = @"\b(while|for|if|else|return|cout|cin|int|float|double|char|void|main|class|public|private|protected|struct|new|delete|switch|case|break|continue|static|extern|const|inline|friend|typedef)\b";
    string identifierPattern = @"[a-zA-Z_]\w*";
    string constantPattern = @"(\d+\.\d*|\d*\.\d+|\d+)";
    string operatorPattern = @"(\+|\-|\*|\/|\%|==|!=|<=|>=|<|>|=|\+\+|\-\-|\+=|-=|\*=|\/=|%=|\^|\&|\||\~|<<|>>|&&|\|\||!|<<=|>>=|&=|\|=|\^=|::)";
    string stringPattern = @"""[^""]*"""; // Cadena de texto entre comillas


    string combinedPattern = string.Format("({0})|({1})|({2})|({3})|({4})|",
        keywordPattern, identifierPattern, constantPattern, operatorPattern, stringPattern);

    MatchCollection matches = Regex.Matches(code, combinedPattern);

    txt2.Clear();
    foreach (Match match in matches)
    {
        if (match.Groups[1].Success)
        {
            txt2.SelectionColor = System.Drawing.Color.Blue;
            txt2.AppendText(match.Value + " = palabra reservada\n");
        }
        else if (match.Groups[2].Success)
        {
            txt2.SelectionColor = System.Drawing.Color.Black;
            txt2.AppendText(match.Value + " = identificador\n");
        }
        else if (match.Groups[3].Success)
        {
            txt2.SelectionColor = System.Drawing.Color.Red;
            txt2.AppendText(match.Value + " = constante numérica\n");
        }
        else if (match.Groups[4].Success)
        {
            txt2.SelectionColor = System.Drawing.Color.Green;
            txt2.AppendText(match.Value + " = operador\n");
        }
        else if (match.Groups[5].Success)
        {
            txt2.SelectionColor = System.Drawing.Color.Purple;
            txt2.AppendText(match.Value + " = cadena de texto\n");
        }
        else if (match.Groups[6].Success)
        {
            txt2.SelectionColor = System.Drawing.Color.Orange;
            txt2.AppendText(match.Value + " = directiva del preprocesador\n");
        }
            }
        }

        private void ParseJavaCode(string codej)
        {
            // Define patrones regex para diferentes componentes
            string keywordPatternj = @"\b(abstract|assert|boolean|break|byte|case|catch|char|class|const|continue|default|do|double|else|enum|extends|final|finally|float|for|if|goto|implements|import|instanceof|int|interface|long|native|new|package|private|protected|public|return|short|static|strictfp|super|switch|synchronized|this|throw|throws|transient|try|void|volatile|while)\b";
            string identifierPatternj = @"[a-zA-Z_]\w*";
            string constantPatternj = @"\b(true|false|null)\b";
            string operatorPatternj = @"(\+|\-|\*|/|%|==|!=|<=|>=|<|>|=)";
            string commentPatternj = @"\/\/.*|\/\*[\s\S]*?\*\/";
            string stringPatternj = "\"(\\.|[^\"])*\"";
            string numberPatternj = @"\b\d+(\.\d+)?\b";

            // Combinar todos los patrones en uno solo
            string combinedPatternj = string.Format("({0})|({1})|({2})|({3})|({4})|({5})",
                keywordPatternj, identifierPatternj, constantPatternj, operatorPatternj, commentPatternj, stringPatternj, numberPatternj);

            // Realizar coincidencias usando el patrón
            MatchCollection matchesj = Regex.Matches(codej, combinedPatternj);

            // Resaltar componentes y mostrarlos en la segunda RichTextBox
            txt2.Clear();
            foreach (Match matchj in matchesj)
            {
                if (matchj.Groups[1].Success) // Palabra clave
                {
                    txt2.SelectionColor = System.Drawing.Color.Blue;
                    txt2.AppendText(matchj.Value + " = palabra clave\n");
                }
                else if (matchj.Groups[2].Success) // Identificador
                {
                    txt2.SelectionColor = System.Drawing.Color.Black;
                    txt2.AppendText(matchj.Value + " = identificador\n");
                }
                else if (matchj.Groups[3].Success) // Constante (true, false, null)
                {
                    txt2.SelectionColor = System.Drawing.Color.Red;
                    txt2.AppendText(matchj.Value + " = constante\n");
                }
                else if (matchj.Groups[4].Success) // Operador
                {
                    txt2.SelectionColor = System.Drawing.Color.Green;
                    txt2.AppendText(matchj.Value + " = operador\n");
                }
                else if (matchj.Groups[5].Success) // Comentario
                {
                    txt2.SelectionColor = System.Drawing.Color.Gray;
                    txt2.AppendText(matchj.Value + " = comentario\n");
                }
                else if (matchj.Groups[6].Success) // Cadena
                {
                    txt2.SelectionColor = System.Drawing.Color.Purple;
                    txt2.AppendText(matchj.Value + " = cadena\n");
                }
                else if (matchj.Groups[7].Success) // Número
                {
                    txt2.SelectionColor = System.Drawing.Color.Orange;
                    txt2.AppendText(matchj.Value + " = número\n");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cb.SelectedIndex = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i;
            i = cb.SelectedIndex;
            if (i == 0)
            {
                string code = txt1.Text;
                ParseCPlusPlusCode(code);
            }
            else if (i==1)
            {
                string code = txt1.Text;
                ParseJavaCode(code);
            }
            else
            {
                MessageBox.Show("por favor seleccione un lenguaje");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the filter to .txt files
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                // Read the contents of the selected .txt file
                string fileContents = System.IO.File.ReadAllText(fileName);

                // Load the file contents into the RichTextBox
                txt1.Text = fileContents;
            }
    }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            // Set the default filter to .txt files
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.DefaultExt = "txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                // Get the content of the RichTextBox
                string content = txt2.Text;

                // Write the content to the selected file
                System.IO.File.WriteAllText(fileName, content);

                MessageBox.Show("Archivo guardado correctamente");
            }
    }
    }
}

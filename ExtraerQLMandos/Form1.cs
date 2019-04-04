using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class frmIndicaciones : Form
    {
        List<string> sListaSinRepetidos = new List<string>();

        public frmIndicaciones()
        {
            InitializeComponent();
        }
        
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string sOpenArchivo;
            
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = false;
            open.Filter = "All files|*.sv";
            open.ShowDialog();

            sOpenArchivo = open.FileName;
            ExtraerQLs(sOpenArchivo);

            CrearArchivo(sOpenArchivo);                       

        }

        private void ExtraerQLs(string sArchivo)
        { 
            string line;
            List<string> sList =new List<string>();
                                                
            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(@sArchivo);

                while ((line = file.ReadLine()) != null)
                {
                    if (line.IndexOf("_QL") != -1 & line.IndexOf("#") == -1)
                    {
                        Regex pattern = new Regex(@"\w*_QL", RegexOptions.Compiled | RegexOptions.IgnoreCase);
                        
                        MatchCollection matches = pattern.Matches(line);

                        foreach(Match m in matches){                            
                            sList.Add(m.Value);                           
                        }

                    }
                }
                sList.Sort();
                sListaSinRepetidos = sList.Distinct().ToList();
            }
            catch
            {
                MessageBox.Show("Error leyendo archivo: " + sArchivo);   
            }              
        
        }

        private void CrearArchivo(string sOpenArchivo)
        {
            string sArchivo;
            int i;

            SaveFileDialog save = new SaveFileDialog();
            MessageBox.Show("Pulsa Aceptar e introduce el nombre de archivo que se generará.");               
            save.ShowDialog();

            try
            {
                sArchivo = save.FileName;
                System.IO.StreamWriter file = new System.IO.StreamWriter(@sArchivo);

                
                //Escribo una cabecera
                file.WriteLine("# " + DateTime.Now + " -- Archivo generado indicaciones del archivo de mandos: " + sOpenArchivo);
                
                //Relleno con la lista de indicaciones de la lista
                for (i = 0; i < sListaSinRepetidos.Count ; i++)
                {
                    if (sListaSinRepetidos[i].IndexOf("_QL") != -1)
                    {
                        file.WriteLine(sListaSinRepetidos[i]);
                    }
                }

                
                file.Close();
                MessageBox.Show("Proceso Completado.");

            }
            catch
            {
                MessageBox.Show("Error creando el archivo.");
            }

        }

    }
}

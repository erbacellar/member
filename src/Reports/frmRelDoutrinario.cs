using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashInBox
{
    public partial class frmRelDoutrinario : Form
    {
        public frmRelDoutrinario()
        {
            InitializeComponent();
        }

        private async void frmRelDoutrinario_Load(object sender, EventArgs e)
        {
            var membros = await MembroDAO.ObterMembros();
            pgbLoad.Maximum = membros.Count();
            var membrosPorPeso = await MembroDAO.GetMembrosPesoGrupo();

            foreach (MembroPeso member in membrosPorPeso)
            {
                string fezCurso = "";
                string cursos = "";
                string livros = "";

                if (member.Membro.FezCurso)
                {
                    fezCurso = "Sim";

                    if (member.Membro.CursoCoem)
                    {
                        cursos += "Coem";
                    }
                    if (member.Membro.CursoEsde)
                    {
                        if (!cursos.Equals(""))
                            cursos += ", ";
                        cursos += "Esde";
                    }
                    if (member.Membro.CursoPbde)
                    {
                        if (!cursos.Equals(""))
                            cursos += ", ";
                        cursos += "Pbde";
                    }
                    if (member.Membro.CursoOutros)
                    {
                        if (!cursos.Equals(""))
                            cursos += ", ";
                        cursos += "Outros";
                    }
                }
                else
                {
                    fezCurso = "Não";
                }

                if (member.Membro.JaLeuLivrosEspiritas)
                {
                    livros = member.Membro.QuaisLivros;
                }

                dsDoutrinario.Doutrinario.AddDoutrinarioRow(member.Membro.Nome, member.Membro.GrupoDia + " " + member.Membro.GrupoHorario, 
                    member.Membro.GrauInstrucao, member.Membro.Profissao, fezCurso, cursos, livros);

                pgbLoad.Value++;
            }

            this.rptRelFinanceiro.RefreshReport();
            
            pgbLoad.Value = 0;
        }

        private void frmRelDoutrinario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.rptRelFinanceiro.Dispose();
        }
    }
}

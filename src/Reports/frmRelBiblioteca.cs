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
    public partial class frmRelBiblioteca : Form
    {
        public frmRelBiblioteca()
        {
            InitializeComponent();
        }

        private async void frmRelBiblioteca_Load(object sender, EventArgs e)
        {
            var membrosPeso = await MembroDAO.GetMembrosPesoGrupo();
            if (membrosPeso.Any())
            {
                membrosPeso = membrosPeso.Where(x => x.Membro.Isento.HasValue && !x.Membro.Isento.Value).OrderBy(x => x.Peso);

                foreach (var item in membrosPeso)
                {
                    var membro = item.Membro;
                    var peso = item.Peso;
                    dsRelatorioBiblioteca.RelatorioBiblioteca.AddRelatorioBibliotecaRow(
                        membro.Nome,
                        membro.Cpf,
                        membro.Rg,
                        membro.GrupoDia,
                        membro.GrupoHorario,
                        membro.Cep,
                        membro.Logradouro,
                        membro.Bairro,
                        membro.Cidade,
                        membro.Estado,
                        membro.NumEnd,
                        membro.Telefone1,
                        membro.Telefone2,
                        membro.Telefone3,
                        membro.Telefone4,
                        peso);

                }
            }

            this.rptRelatorioBiblioteca.RefreshReport();
        }

        private void frmRelBiblioteca_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.rptRelatorioBiblioteca.Dispose();
        }
    }
}

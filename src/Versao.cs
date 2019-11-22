using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Reflection;
using System.Deployment.Application;

namespace CashInBox
{
    class Versao
    {
        #region Atributos


        #endregion

        #region Propriedades

        #endregion

        #region Métodos
        //Aqui ficarão os métodos

        public string Obter()
        {
            //return PublishVersion;
            return "1.0.0.0";
        }

        private string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string PublishVersion
        {
            get
            {
                return ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            }
        }

        #endregion
    }
}

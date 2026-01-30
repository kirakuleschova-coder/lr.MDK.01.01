using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr_3
{
    internal class Tovar
    {
        private string name_;
        private string postavshik_;
        private string proizvoditel_;
        private int summa_;
        private double nomeclaturnGroup_;
        private string foto_;

        public string Name
        {
            get { return name_; }
        }

            public string Symma
        {
            get { return Convert.ToString(summa_); }
        }


            public string NomeclaturnGroup_
        {
            get { return Convert.ToString(nomeclaturnGroup_); }
        }


        public string Postavshik
        {
            get {return Convert.ToString(postavshik_); }
        }

        public string Proizvoditel
        {
            get { return Convert.ToString(proizvoditel_); }
        }

        public string Foto
        {
            get { return foto_; }
        }

    }
}

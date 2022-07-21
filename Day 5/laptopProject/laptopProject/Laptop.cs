using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptopProject
{
    class Laptop
    {
        #region Data  Fields
        string _laptopName;
        int _model_number;
        float _amount;
        byte _ram;
        #endregion

        #region constructors
        ///<summary> Constructor
        public Laptop()
        {

        }
        ///<summary>
        /// parameterized constructor
        ///</summary>
        ///

        public Laptop(string laptopName, int modelNumber, float amount, byte ram)
        {
            this._laptopName = laptopName;
            this._model_number = modelNumber;
            this._amount = amount;
            this._ram = ram;
        }
        #endregion


        #region properties
       public string GetLaptopName()
        {
            return _laptopName;
        }

        public int GetModelNumber()
        {
            return _model_number;
        }
        public float GetAmount()
        {
            return _amount;
        }
        public byte GetRam()
        {
            return _ram;
        }

        public void SetLaptopName(string laptopName)
        {
            if(laptopName.Length != 0)
            {
                this._laptopName = laptopName;
            }
        }

        public void SetModelNumber(int modelNumber)
        {
            if(modelNumber != 0)
            {
                this._model_number = modelNumber;
            }
        }

        public void SetAmount(float amount)
        {
            if (amount != 0)
            {
                this._amount = amount;
            }
        }

        public void SetRam(byte ram)
        {
            if (ram != 0)
            {
                this._ram = ram;
            }
        }

        #endregion
    }
}

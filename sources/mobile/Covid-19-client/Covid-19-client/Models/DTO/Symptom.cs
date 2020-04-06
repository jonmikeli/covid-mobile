using Covid19Client.Models.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

namespace Covid19Client.Models.DTO
{
    public class Symptom
    {
        #region ctor
        public Symptom()
        {
            // public empty ctor needed for serialization
        }
        #endregion
        #region Temperature
        [Required()]
       public bool Temperature { get; set; }
        public int TemperatureValue { get; set; }
        public string TemperatureDescription { get; set; }
        [Required()]
        public TemperatureUnity TemperatureUnity { get; set; }
        #endregion
        #region MuscularPain
        [Required()]
        public bool MuscularPain { get; set; }
        [Range(1, 5)]
        public int MuscularPainLevel { get; set; }
        public string MuscularPainDescription { get; set; }
        #endregion
        #region Cough
        [Required()]
        public bool Cough{get;set;}
        [Range(1, 5)]
        public int CoughLevel { get; set; }
        public string CoughDescription { get; set; }
        #endregion
        #region Others
        [Required()]
        public bool SmellLoss { get; set; }
        public string SmellLossDescription { get; set;}
        [Required()]
        public bool TasteLoss { get; set; }
        public string TasteLossDescription { get; set; }
        [Required()]
        public bool Headaches { get; set; }
        public string HeadachesDescription { get; set; }
        [Required()]
        public bool Improving { get; set; }
        public string Others { get; set; }
        #endregion
    }
}

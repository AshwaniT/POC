using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    [Serializable]
    public class CustomizedText
    {
        public int Id { get; set; }
        public string Token { get; set; }
        public int ZOrder { get; set; }
        public double OriginX { get; set; }
        public double OriginY { get; set; }
        public string Text { get; set; }
        public bool IsBold { get; set; }
        public bool IsItalic { get; set; }
        public double FontSize { get; set; }
        public string FontStyle { get; set; }
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public double RotationalDegree { get; set; }
        public DateTime DateUpdated { get; set; }
        public int CustomizedProductId { get; set; }
        public int? VersionNumber { get; set; }
        public DateTime LastAccessedDate { get; set; }
    }
}
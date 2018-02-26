using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    [Serializable]
    public class ZOrderInfo
    {
        public int SpriteId { get; set; }
        public string Token { get; set; }
        public int ZOrder { get; set; }
        public SpriteType SpriteType { get; set; }
    }
}
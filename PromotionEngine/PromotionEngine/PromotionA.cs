using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public class PromotionA : PromotionSKU
    {
        public PromotionA(List<ISKU> lsku) : base(lsku) 
        {

        }
        public override int Cost()
        {
            List<ISKU> tempList = base._lSku.Where(x => x is skuA).ToList();
            if(tempList.Count > 0)
                return (tempList.Count / 3) * 130 + (tempList.Count % 3) * tempList.FirstOrDefault().Cost();
            return 0;
        }
    }
}

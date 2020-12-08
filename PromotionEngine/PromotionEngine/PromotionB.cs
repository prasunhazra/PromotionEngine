using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public class PromotionB : PromotionSKU
    {
        public PromotionB(List<ISKU> lsku) : base(lsku)
        {

        }
        public override int Cost()
        {
            List<ISKU> tempList = base._lSku.Where(x => x is skuB).ToList();
            if(tempList.Count > 0)
                return (tempList.Count / 2) * 45 + (tempList.Count % 2) * tempList.FirstOrDefault().Cost();
            return 0;
        }
    }
}

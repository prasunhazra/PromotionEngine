using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public class PromotionCD : PromotionSKU
    {
        public PromotionCD(List<ISKU> lsku) : base(lsku)
        {

        }
        public override int Cost()
        {
            List<ISKU> tempList = base._lSku.Where(x => x is skuC || x is skuD).ToList();
            if (tempList.Count > 0)
            {
                List<ISKU> tempListC = tempList.Where(x => x is skuC).ToList();
                List<ISKU> tempListD = tempList.Where(x => x is skuD).ToList();
                if(tempListC.Count == tempListD.Count)
                {
                    return tempListC.Count * 30;
                }
                if(tempListC.Count < tempListD.Count)
                {
                    return tempListC.Count * 30 + (tempListD.Count - tempListC.Count) * 15;
                }
                if(tempListC.Count > tempListD.Count)
                {
                    return tempListD.Count * 30 + (tempListC.Count - tempListD.Count) * 20;
                }
                
            }
            return 0;
        }
    }
}

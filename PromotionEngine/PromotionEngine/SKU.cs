using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    interface ISKU
    {
        int Cost();
    }

    abstract class PromotionSKU : ISKU
    {
        private List<ISKU> _lSku;
        public PromotionSKU(List<ISKU> lsku)
        {
            _lSku = lsku;
        }
        public abstract int Cost();
    }
}

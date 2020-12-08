using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public interface ISKU
    {
        int Cost();
    }

    public abstract class PromotionSKU : ISKU
    {
        protected List<ISKU> _lSku;
        public PromotionSKU(List<ISKU> lsku)
        {
            _lSku = lsku;
        }
        public virtual int Cost()
        {
            return _lSku.FirstOrDefault().Cost();
        }
    }

    public class skuA : ISKU
    {
        public int Cost()
        {
            return 50;
        }
    }

    public class skuB : ISKU
    {
        public int Cost()
        {
            return 30;
        }
    }

    public class skuC : ISKU
    {
        public int Cost()
        {
            return 20;
        }
    }

    public class skuD : ISKU
    {
        public int Cost()
        {
            return 15;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4_hyrol.Strategy
{
    public class Image
    {
        private readonly IImage loadingStrategy;

        public Image(IImage loadingStrategy)
        {
            this.loadingStrategy = loadingStrategy;
        }

        public void Load(string href)
        {
            loadingStrategy.LoadImage(href);
        }
    }
}

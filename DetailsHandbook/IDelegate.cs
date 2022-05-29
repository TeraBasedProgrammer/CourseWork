using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DetailsHandbook
{
    public interface IDelegate
    {
        public delegate void SearchResultHandler();

        public delegate void ButtonRenderHandler(WrapPanel wp, Detail detail);

        public delegate void ReRenderHandler();
    }
}

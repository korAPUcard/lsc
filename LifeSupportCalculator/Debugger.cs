using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LifeSupportCalculator
{
    internal class Debugger
    {
        public static void GetAllComponents()
        {
            Form form = new Form();

            // 컨트롤 컬렉션 가져오기
            Control.ControlCollection controls = form.Controls;

            // 컨트롤 이름 출력
            foreach (Control control in controls)
            {
                Console.WriteLine(control.Name);
            }
        }
    }
}

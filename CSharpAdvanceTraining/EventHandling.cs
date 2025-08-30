using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    class EventHandling
    {
        private int value;
        public delegate void NumChangeHandler();
        public delegate string OnSaveHandler(string s);
        public event NumChangeHandler NumberChanged;
        public event OnSaveHandler OnSave;

        public EventHandling(int n)
        {
            SetValue(n);
        }

        public void OnNumChanged() {

            if (NumberChanged != null)
                NumberChanged();
            else
                Console.WriteLine("Handled via function");
        }

        public static void NumberHandler() {
            Console.WriteLine("Handled via Delegate");
        }

        public static string Saved(string s)
        {
            return s ;
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumChanged();
                if (OnSave != null)
                {
                    string result = OnSave("Saved Successfully");
                    Console.WriteLine(result);
                }
            }
        }
        static void Main(string[] args)
        {
            var obj = new EventHandling(10);
            obj.OnSave += new OnSaveHandler(Saved);
            obj.NumberChanged += new NumChangeHandler(NumberHandler);
            obj.SetValue(20);
            obj.NumberChanged -= new NumChangeHandler(NumberHandler);
            obj.SetValue(30);
        }
    }
}
    
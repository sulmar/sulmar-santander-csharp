using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlConsoleApp.Model
{
    internal class Window
    {
        public string Title;

        public List<Control> Children;

        public Window()
        {
            Children = new List<Control>();

            Children.Add(new TextBox { Label = "First name", Value = "John", Width = 100, Height = 200 });
            Children.Add(new CheckBox { Name = "HasAlert", Value = true, Width = 100, Height = 200 });
            Children.Add(new Button { Name = "Save", Width = 100, Height = 200 });
            Children.Add(new MapControl { Name = "Mapa", CenterLatitude = 51.01, CenterLongitude = 21.01, Zoom = 11 });
        }

        public void Render()
        {
            foreach (Control control in Children)
            {
                control.Render();
            }
        }
    }

    class TextBox : Control
    {
        public string Label;
        public string Value;

        public override void Render()
        {
            Console.WriteLine($"{Label}: [ {Value} ] {Width} x {Height}");
        }
    }

    class CheckBox : Control
    {
        public bool Value;

        public override void Render()
        {
            Console.WriteLine($"{Name} [ {Value} ] {Width} x {Height}");
        }
    }

    class Button : Control
    {
        public override void Render()
        {
            Console.WriteLine($"[ {Name} ] {Width} x {Height}");
        }
    }

    class MapControl : Control
    {
        public double CenterLatitude;
        public double CenterLongitude;
        public double Zoom;

        public override void Render()
        {
            Console.WriteLine($"[ {Name} ] {Width} x {Height} {Zoom:P2} ({CenterLatitude},{CenterLongitude})");
        }
    }


    abstract class Control
    {      
        public string Name;
        public int Width;
        public int Height;
      //  public ControlType ControlType;

        // MapControl
       
        
        // public object Value;

        public void Focus()
        {

        }

        public virtual void Render()
        {
            Console.WriteLine($"{Width} x {Height}");
        }

      

    }



}

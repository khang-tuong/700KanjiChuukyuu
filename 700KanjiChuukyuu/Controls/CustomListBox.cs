using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreService.Model;

namespace _700KanjiChuukyuu.Controls
{
    public partial class CustomListBox : ListBox
    {
        public CustomListBox()
        {
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.ItemHeight = 70;
            InitializeComponent();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            //Tránh lỗi lúc refresh
            if (e.Index >= 0)
            {
                // If the item is the selected item, then draw the rectangle
                // filled in blue. The item is selected when a bitwise And  
                // of the State property and the DrawItemState.Selected 
                // property is true.
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    e.Graphics.FillRectangle(Brushes.CornflowerBlue, e.Bounds);
                    e.Graphics.DrawString(this.Items[e.Index].ToString(),
                    new Font("HanaMinA", 14), Brushes.White, e.Bounds.X, e.Bounds.Y + 5);
                }
                else
                {
                    // Otherwise, draw the rectangle filled in beige.
                    e.Graphics.FillRectangle(Brushes.White, e.Bounds);
                    e.Graphics.DrawString(this.Items[e.Index].ToString(),
                    new Font("HanaMinA", 14), Brushes.Black, e.Bounds.X, e.Bounds.Y + 5);
                }

                // Draw a rectangle in blue around each item.
                //e.Graphics.DrawRectangle(Pens.Blue, e.Bounds);

                // Draw the text in the item.


                // Draw the focus rectangle around the selected item.
                e.DrawFocusRectangle();
            }
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            e.ItemHeight += 40;
        }

        public void AddWord(Word w)
        {
            this.Items.Add(w);
        }

        public void AddPhrasse(Phrase p)
        {
            this.Items.Add(p);
        }
    }
}

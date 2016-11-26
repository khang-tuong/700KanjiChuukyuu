using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _700KanjiChuukyuu.Controls
{
    public partial class CustomSelectBox : ComboBox
    {
        private string selectedText = "";
        public CustomSelectBox()
        {
            InitializeComponent();
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.DropDownStyle = ComboBoxStyle.DropDown;
            this.AutoCompleteSource = AutoCompleteSource.CustomSource;
            this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.ItemHeight = 30;
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

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            this.selectedText +=  (string)this.SelectedItem + " ";
            this.Text = this.selectedText;
            MessageBox.Show("OnSelectedIndexChanged");
        }

        protected override void OnTextChanged(EventArgs e)
        {
            MessageBox.Show("OnTextChanged");
        }
    }
}

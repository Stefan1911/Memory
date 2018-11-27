using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace dataLib
{
    public class card : PictureBox
    {
        Bitmap front;
        Bitmap back;
        int pictureIndex;

        bool reveled;
        bool emptyCard;

        public card(string imgPath, string backPath, bool isEmpltycard, int pictureIndex)
        {
            this.front = new Bitmap(imgPath, true);
            this.back = (backPath != null)?new Bitmap(backPath, true):null;
            this.pictureIndex = pictureIndex;
            this.Image = this.back;
            reveled = false;
            emptyCard = isEmpltycard;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public Bitmap Front { get => front;  }
        public Bitmap Back { get => back;  }
        public bool Reveled { get => reveled; }
        public bool EmptyCard { get => emptyCard; }

        public void flipCard()
        {
            if (this.Image == this.front)
            {
                this.Image = this.back;
                reveled = false;
            }
            else
            {
                this.Image = this.front;
                reveled = true;
            }
                
        }
        public bool compereTo(card arg)
        {
           return (this.pictureIndex == arg.pictureIndex) ? true : false;
        }

        public void setCardBack(string path)
        {
            this.back = new Bitmap(path, true);
            if (!this.reveled)
                this.Image = this.back;
        }
        public void resetCardBack()
        {
            this.back = null;
            if(!this.reveled)
                this.Image = this.back;
        }
    }
}

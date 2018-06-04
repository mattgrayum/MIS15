using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmLionImage : Form
    {
        const int Wide = 676;
        const int High = 611;
        public frmLionImage()
        {
            InitializeComponent();   
            this.Width = Wide+18;
            this.Height = High+47;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color foreColor = Color.Black;
            Color backColor1 = Color.Tomato;
            Color backColor2 = Color.Yellow;
            Point grdntPt1 = new Point { X = Wide / 2, Y = High };
            Point grdntPt2 = new Point { X = Wide / 2, Y = 0 };
            Pen forePen = new Pen(foreColor, 2);
            Brush foreBrush = new SolidBrush(foreColor);
            Pen backPen = new Pen(Color.Transparent, 1);
            Brush backBrush1 = new LinearGradientBrush(grdntPt1, grdntPt2, backColor1, backColor2);
            Brush backBrush2 = new SolidBrush(Color.Transparent);
            Brush backBrush3 = new SolidBrush(Color.Goldenrod);
            int[] coordArr;

            //Background color

            //g.FillRectangle(backBrush1, 0, 0, 676, 611);    //Gradient red to yellow

            g.FillRectangle(backBrush3, 0, 0, 676, 611);    //Goldenrod

            //Nose

            //nose
            coordArr = new int[30] {338, 334, 335, 334, 335, 318, 332, 306, 325, 298, 309, 290, 303,
                                    289, 301, 286, 300, 281, 307, 283, 312, 280, 320, 275, 328, 277,
                                    334, 280, 338, 280};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //nose lines
            coordArr = new int[16] { 299, 273, 296, 267, 299, 260, 312, 241, 315, 234, 313, 247, 306, 260, 299, 273 };
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //Eyes and surrounding

            //eyes
            coordArr = new int[34] {257, 200, 263, 202, 272, 196, 277, 195, 287, 197, 295, 203, 299,
                                    208, 300, 220, 308, 233, 298, 220, 294, 211, 286, 207, 281, 205,
                                    274, 208, 272, 215, 267, 207, 257, 200};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //pupils
            coordArr = new int[6] { 285, 207, 285, 218, 287, 208 };
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //upper nose lines between eyes
            coordArr = new int[34] {313, 182, 315, 185, 312, 194, 311, 196, 309, 200, 311, 205, 316, 208, 316, 218,
                                    316, 222, 315, 216, 312, 211, 308, 208, 302, 202, 306, 194, 309, 189, 312, 183,
                                    313, 178};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //under eyes
            coordArr = new int[16] { 302, 237, 289, 233, 267, 224, 261, 211, 273, 221, 286, 224, 293, 229, 302, 237 };
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //cheekbones
            coordArr = new int[16] { 273, 280, 260, 273, 252, 260, 250, 243, 253, 248, 257, 255, 272, 263, 273, 280 };
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //cheek skin
            coordArr = new int[12] { 273, 313, 273, 300, 277, 290, 286, 283, 277, 298, 273, 313 };
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //forhead line (center)
            coordArr = new int[10] { 338, 183, 335, 164, 338, 143, 341, 164, 338, 183 };
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //Ears and surrounding

            //hair under ear
            coordArr = new int[22] {208, 235,219, 221, 222, 208, 229, 190, 248, 181, 247, 189, 247, 195, 237, 204,
                                    231, 220, 222, 229, 208, 235};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //inside of ears
            coordArr = new int[22] {221, 169, 211, 156, 209, 143, 221, 131, 234, 133, 247, 140, 260, 146, 247, 159,
                                    254, 159, 248, 170, 221, 169};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //ear tabs
            coordArr = new int[8] { 221, 169, 209, 176, 220, 168, 221, 169 };
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //top of ears
            coordArr = new int[38] {215, 170, 204, 156, 200, 143, 204, 130, 221, 118, 247, 120, 267, 127, 286,
                                    120, 260, 117, 273, 111, 286, 111, 308, 117, 283, 127, 270, 143, 234, 127,
                                    211, 132, 205, 143, 208, 156, 215, 170};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //center tuft of hair --- a single asymmetrical shape
            coordArr = new int[40] {338, 130, 332, 120, 319, 117, 306, 107, 287, 98, 312, 101, 332, 113, 328,  91,
                                    321,  78, 306,  65, 325,  72, 338,  81, 348, 104, 346, 114, 352, 101, 358, 85,
                                    364, 104, 364, 117, 350, 120, 338, 130};
            Point[] ptArr = new Point[38 / 2];
            getPointArray(coordArr, out ptArr);
            g.DrawCurve(forePen, ptArr);
            g.FillClosedCurve(foreBrush, ptArr);

            //Beard and chin

            //beard --- s single asymmetrical shape
            coordArr = new int[148] {244, 211, 230, 242, 222, 248, 208, 280, 212, 312, 221, 338, 221, 325, 218, 312,
                                     224, 280, 224, 293, 241, 319, 247, 351, 247, 377, 254, 390, 251, 384, 260, 358,
                                     273, 384, 276, 387, 276, 390, 280, 419, 304, 442, 319, 470, 320, 460, 309, 436, 341, 460,
                                     351, 507, 359, 481, 361, 455, 371, 437, 390, 416, 384, 436, 385, 443, 395, 429,
                                     410, 410, 413, 390, 410, 371, 423, 351, 429, 377, 436, 364, 437, 351, 436, 338,
                                     442, 312, 450, 299, 454, 287, 452, 280, 456, 299, 454, 325, 455, 341, 460, 325,
                                     468, 312, 468, 299, 469, 286, 460, 260, 448, 241, 436, 217, 442, 247, 439, 273,
                                     435, 292, 427, 299, 405, 323, 404, 344, 392, 352, 386, 352, 338, 334, 289, 352,
                                     283, 352, 273, 343, 271, 338, 271, 325, 248, 299, 240, 292, 234, 273, 235, 234,
                                     243, 211};
            ptArr = new Point[148 / 2];
            getPointArray(coordArr, out ptArr);
            g.DrawCurve(forePen, ptArr);
            g.FillClosedCurve(foreBrush, ptArr);

            //chin in middle of beard
            coordArr = new int[18] {338, 391, 312, 390, 299, 382, 293, 371, 299, 354, 312, 348, 328, 344, 338, 351,
                                    338, 391};

            //symHorizCurve(g, backPen, backBrush1, coordArr);    // With gradient red to yellow background

            symHorizCurve(g, backPen, backBrush3, coordArr);    // With goldenrod background

            // Mane Sections

            //mane section 1
            coordArr = new int[46] {117, 416, 104, 377,  98, 338,  97, 325,  98, 312, 104, 286, 116, 260, 131, 235,
                                    144, 221, 160, 209, 156, 221, 140, 247, 127, 273, 117, 299, 114, 325, 113, 332,
                                    114, 338, 117, 364, 130, 338, 146, 322, 143, 342, 140, 364, 117, 416};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //mane section 2
            coordArr = new int[28] {114, 263, 117, 234, 127, 195, 137, 169, 150, 150, 170, 134, 182, 129, 195, 129,
                                    177, 143, 164, 154, 146, 182, 137, 208, 130, 247, 114, 263};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //mane section 3
            coordArr = new int[42] {142, 169, 143, 155, 153, 130, 166, 104, 174,  92, 187,  75, 210,  60, 220,  57,
                                    234,  55, 247,  56, 280,  70, 260,  66, 247,  65, 234,  67, 221,  73, 208,  80,
                                    195,  92, 182, 108, 169, 130, 163, 146, 142, 169};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //mane section 4
            coordArr = new int[36] {198,  62, 221,  46, 247,  29, 289,  26, 286,  25, 312,  27, 325,  30, 338,  36,
                                    338,  55, 325,  49, 312,  42, 299,  40, 286,  39, 273,  40, 260,  43, 247,  49,
                                    234,  55, 198,  62};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //mane section 5
            coordArr = new int[30] {202, 507, 182, 494, 169, 483, 156, 472, 143, 456, 137, 446, 130, 429, 124, 403,
                                    142, 361, 140, 377, 143, 416, 156, 446, 173, 465, 195, 478, 202, 507};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //mane section 6
            coordArr = new int[40] {260, 540, 247, 532, 234, 520, 221, 512, 208, 501, 195, 488, 182, 475, 169, 455,
                                    165, 429, 168, 416, 172, 403, 176, 416, 179, 429, 185, 442, 192, 455, 202, 468,
                                    210, 481, 231, 494, 244, 507, 260, 540};
            symHorizCurve(g, forePen, foreBrush, coordArr);

            //bottom of mane --- a single asymmetrical shape
            coordArr = new int[130] {260, 540, 244, 520, 234, 507, 235, 494, 237, 481, 241, 468, 247, 455, 260, 443,
                                     260, 468, 264, 481, 270, 494, 279, 507, 293, 520, 296, 512, 299, 502, 312, 514,
                                     317, 520, 324, 533, 326, 546, 328, 559, 328, 562, 338, 559, 351, 553, 364, 546,
                                     374, 533, 380, 520, 390, 501, 392, 514, 390, 527, 403, 514, 413, 494, 417, 481,
                                     417, 468, 417, 445, 429, 463, 432, 468, 440, 481, 442, 494, 441, 507, 416, 540,
                                     423, 520, 422, 507, 416, 520, 406, 533, 393, 546, 374, 559, 348, 572, 312, 585,
                                     313, 559, 312, 546, 302, 533, 304, 546, 296, 560, 296, 553, 293, 545, 286, 538,
                                     281, 533, 273, 527, 267, 520, 260, 507, 252, 488, 248, 494, 250, 507, 253, 520,
                                     260, 540};
            ptArr = new Point[65/ 2];
            getPointArray(coordArr, out ptArr);
            g.DrawCurve(forePen, ptArr);
            g.FillClosedCurve(foreBrush, ptArr);

            //crossHairs(g, 291, 520);
        }

        private void crossHairs (Graphics g, int x, int y)
        /*places corsshairs at a given point to aid in finding coordinates for editing*/
        {
            Pen pen = new Pen(Color.Black, 1);
            g.DrawLine(pen, x, 0, x, High);
            g.DrawLine(pen, 0, y, Wide, y);
        }

        private void symHorizCurve(Graphics g, Pen pen, Brush brush, int[] leftArr)
        /*takes an array of coordinates, passes them to a function that returns a mirror image array,
        then passes each array of coordinates to a function that returns a Point array to by used
        by the DrawCurve method*/
        { 
            int[] rightArr = new int[leftArr.GetLength(0)];
            Point[] ptArr = new Point[leftArr.GetLength(0) / 2];

            getMirrorImageArr(leftArr, out rightArr);
            
            //left side
            getPointArray(leftArr, out ptArr);
            g.DrawCurve(pen, ptArr);
            g.FillClosedCurve(brush, ptArr);

            //right side
            getPointArray(rightArr, out ptArr);
            g.DrawCurve(pen, ptArr);
            g.FillClosedCurve(brush, ptArr);
        }

        private void getMirrorImageArr(int[] leftArr, out int[] rightArr)
        /*Takes an array of coordinates and returns an array that is a mirror image about the y axis*/
        {
            int arrSize = leftArr.GetLength(0);
            rightArr = new int[arrSize];

            for (int i = 0; i < arrSize; i = i + 2)
            {
                rightArr[i] = Wide - leftArr[i];    // gets a mirror image x coordinate
                rightArr[i + 1] = leftArr[i + 1];   // y corrdinate is unchanged
            }
        }

        private void getPointArray(int[] arr, out Point[] ptArr)
        /*Takes an array of integer coordinates and converts them to an array of Point objects*/
        {
            int coordArrSize = arr.GetLength(0);
            ptArr = new Point[coordArrSize/2];  //half the size because each Point uses two coordinates
           
            for (int i = 0; i < coordArrSize; i = i+2)
            {
                ptArr[i/2] = new Point { X = arr[i], Y = arr[i + 1] }; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }
  

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeastSquare
{
    public partial class Form1 : Form
    {
        double xmin = -2, xmax = 7;
        double ymin = -5, ymax = 70;
        private float xpixel(double xw)
        {
            return (float)(picdraw.ClientSize.Width * (xw - xmin) / (xmax - xmin));
        }
        private float ypixel(double yw)
        {
            return (float)(picdraw.ClientSize.Height * (1-(yw - ymin) / (ymax - ymin)));
        }
        private float matrix1(double m1,double m2, double m3)
        {
            double[] a = new double[3] { m1, m2, m3 };
            return 0;
        }
        private double d(double a11,double a12, double a13, double a21,double a22, double a23, double a31, double a32,double a33)
        {
            double sum;
            sum = a11 * (a22 * a33 - a23 * a32) - a12 * (a21 * a33 - a23 * a31) + a13 * (a21 * a32 - a22 * a31);
            return sum;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //데이터세팅
            const int n=6;
            double[] xw = new double[n] { 1, 2, 3, 4, 5, 6 };
            double[] yw = new double[n] { 2.1, 7.7, 13.6, 27.2, 40.9, 61.1 };
            //좌표그리기
            Graphics grp = picdraw.CreateGraphics();
            grp.DrawLine(new Pen(Color.Black), xpixel(xmin), ypixel(0),
                xpixel(xmax), ypixel(0));
            grp.DrawLine(new Pen(Color.Black), xpixel(0), ypixel(ymin),
               xpixel(0), ypixel(ymax));
           
            for (int i = 0; i < n; i++)
            {
                grp.DrawEllipse(new Pen(Color.Red), xpixel(xw[i]), ypixel(yw[i]),2,2);
            }
            double sumXY = 0, sumX = 0, sumY = 0, sumXX = 0, sumXXX = 0, sumXXXX=0,sumXXY=0 ;
            for(int i=0;i<n;i++)
            {
                sumXY += xw[i] * yw[i];
                sumX += xw[i];
                sumY += yw[i];
                sumXX += xw[i] * xw[i];
                sumXXX += xw[i] * xw[i]*xw[i];
                sumXXXX += xw[i] * xw[i] * xw[i]*xw[i];
                sumXXY += xw[i] * xw[i]*yw[i];
            }
            double d4 = d(n, sumX, sumXX, sumX, sumXX, sumXXX, sumXX, sumXXX, sumXXXX);
            double d0 = d(sumY, sumX, sumXX, sumXY, sumXX, sumXXX, sumXXY, sumXXX, sumXXXX);
            double d1 = d(n, sumY, sumXX, sumX, sumXY, sumXXX, sumXX, sumXXY, sumXXXX);
            double d2 = d(n, sumX, sumY, sumX, sumXX, sumXY, sumXX,sumXXX, sumXXY);

            double a0 = d0 / d4;
            double a1 = d1 / d4;
            double a2 = d2 / d4;

            double prexw, preyw,x=0,y=0;

            for (prexw = xmin; prexw < xmax; prexw += 0.01)
            {
                preyw = a0 + a1 * prexw + a2 * prexw * prexw;

                if (prexw == xmin) {
                    grp.DrawLine(new Pen(Color.Red), xpixel(prexw), ypixel(preyw), xpixel(prexw), ypixel(preyw));
                    x = prexw;
                    y = preyw;
                }
                    
                grp.DrawLine(new Pen(Color.Red), xpixel(x), ypixel(y), xpixel(prexw), ypixel(preyw));
                x = prexw;
                y = preyw;

            }
             
            
        }
    }
}

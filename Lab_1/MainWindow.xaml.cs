﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GeometryDrawing mainDrawing = new GeometryDrawing();
            Figures mainList = new Figures(mainDrawing);
            mainList.Add(new Line(new Point(10, 10), new Point(20, 50)));
            mainList.Drawing(mainDrawing);
            
        //    mainDrawing.Geometry = paintGroup;                    //вместо paintGroup можно line типа GeometryLine и т.п.
        //    mainPaint.Source = new DrawingImage(mainDrawing);     //две строчки. Для рисования. 
        }
    }
}

using System;
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
using System.Windows.Shapes;

namespace FILLWORDS
{
    /// <summary>
    /// Логика взаимодействия для GameScreen.xaml
    /// </summary>
    public partial class GameScreen : Window
    {
        public Cell[,] ArrayOfCells;
        public GameScreen()
        {
            InitializeComponent();
            ArrayOfCells = new Cell[4, 4];
            Field.ShowGridLines = true;
            SetField(Field,4);
            SetCells(4);
        }

       private void SetField(Grid Field, int rang)
        {
            for (int i=0;i<rang;i++)
            {
                Field.ColumnDefinitions.Add(new ColumnDefinition());
                Field.RowDefinitions.Add(new RowDefinition());
            }
        }

        private void SetCells(int rang)
        {
            for (int x=0;x<rang;x++)
                for (int y=0;y<rang;y++)
                {
                    Polygon temp = new Polygon();
                    temp.Fill = Brushes.Yellow;
                    Grid.SetRow(temp, y);
                    Grid.SetColumn(temp,x);
                    Cell temp1 = new Cell(x,y,temp);
                    ArrayOfCells[x, y] = temp1;
                }
        }
    }

    public class Cell
    {
        public readonly int X;
        public readonly int Y;

        public readonly Polygon LabelHolder;
        public readonly Label LetterHolder;
        public readonly char Letter;

        public Cell(int x,int y, Polygon polygon)
        {
            X = x;
            Y = y;
            LabelHolder = polygon;
        }
    }
    
}

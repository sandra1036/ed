using System;
using Gtk;
using CBingo;
namespace CBingo
{
    public class Panel
    {
        private static uint rows = 9;
        private static uint colum = 10;
        public Panel(VBox vBox)
        {
            Table table = new Table(rows, colum, true);
            int index = 0;
            for (uint row = 0; row < rows; row++)
                for (uint col = 0; col < colum; col++)
                {
                    index++;
                    Button button = new Button();
                    button.Label = index.ToString();
                    table.Attach(button, col, col + 1, row, row + 1);
                }
            table.ShowAll();
            vBox.Add(table);

        }
        public void Marcar(int num) {

        }
    }
}

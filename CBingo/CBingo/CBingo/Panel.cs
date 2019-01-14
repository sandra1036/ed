using System;
using Gtk;
using CBingo;
using System.Collections.Generic;

namespace CBingo
{
    public class Panel
    {
        private static uint rows = 9;
        private static uint colum = 10;

        private IList<Button> buttons= new List<Button>();

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
                    buttons.Add(button);
                }
            table.ShowAll();
            vBox.Add(table);

        }
        public void Marcar(int num) {
            buttons[num-1].ModifyBg(StateType.Normal, new Gdk.Color(0, 255, 0));
        }
    }
}

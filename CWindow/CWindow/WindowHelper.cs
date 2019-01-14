using System;
using Gtk;
namespace CWindow
{
    public class WindowHelper
    {     
        public static bool Confirm(Window window,string message){
            MessageDialog messageDialog = new MessageDialog(
                window,
                DialogFlags.Modal,
                MessageType.Question,
                ButtonsType.YesNo,
                message);
            messageDialog.Title = parentWindow.Title;
            ResponseType response = (ResponseType)messageDialog.Run();
            messageDialog.Destroy();

            return response == ResponseType.Yes;
        }
    }
}

using İNTEKO.UserControls;

namespace INTEKO.DB
{
    public  class Tools
    {
        public static void Message(string msg, MessageForm.enmType type)
        {
            MessageForm frm = new MessageForm();
            frm.showAlert(msg, type);
        }
    }
}

namespace System.Windows.Forms
{
    internal class EventHandler
    {
        private Action<object, EventArgs> dashExit_Click;

        public EventHandler(Action<object, EventArgs> dashExit_Click)
        {
            this.dashExit_Click = dashExit_Click;
        }
    }
}
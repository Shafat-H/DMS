namespace DMS.Views.Controls;

public partial class ItemContent : ContentView
{
    public event EventHandler<string> onError;
    public event EventHandler<EventArgs> onSave;
    public event EventHandler<EventArgs> onCancel;
    public ItemContent()
    {
        InitializeComponent();
    }
    public string Name
    {
        get => entItemName.Text;
        set => entItemName.Text = value;
    }
    public string Description
    {
        get => entDescription.Text;
        set => entDescription.Text = value;
    }
    public string ItemCode
    {
        get => entItemCode.Text;
        set => entItemCode.Text = value;
    }
    public string Price
    {
        get => entPrice.Text;
        set => entPrice.Text = value;
    }

    private void btnSave_Clicked(object sender, EventArgs e)
    {
        if (nameValidator.IsNotValid)
        {
            onError?.Invoke(sender, "Please enter valid item name");
            return;
        }

        if (priceValidator.IsNotValid)
        {

            onError?.Invoke(sender, "Please enter valid item price");
            
            return;
        }
        onSave?.Invoke(sender, e);
    }

    private void Cancel_Clicked(object sender, EventArgs e)
    {
        onCancel?.Invoke(sender, e);
    }
}
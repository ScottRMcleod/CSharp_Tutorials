using ConsignmentShopLibary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsignmentShopUI
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> shoppingCartData = new List<Item>();
        BindingSource cartBinding = new BindingSource();
        BindingSource itemsBinding = new BindingSource();
        BindingSource vendorBinding = new BindingSource();

        //Method to pupulate store with test data
        private void SetupData()
        {
            //e.g 1 Slow way
            /*
            Vendor demoVendor = new Vendor();
            demoVendor.FristName = "Bob";
            demoVendor.LastName = "Smith";
            demoVendor.Comission = .5;
            store.Vendors.Add(demoVendor);*/

            //more eligent popularting the vendor list box with dummy vendors
            store.Vendors.Add(new Vendor { FristName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FristName = "Sue", LastName = "Johns" });

            store.Items.Add(new Item
            {
                Title = "Moby Dick",
                Description = "Book about a Whale",
                Price = 4.50M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Tale Two Cities",
                Description = "Book about Revolations",
                Price = 3.20M,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Harry Potter",
                Description = "Book about wizzards",
                Price = 14.50M,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Jane Eyre",
                Description = "Book about Revolations",
                Price = 1.50M,
                Owner = store.Vendors[1]
            });
            store.Name = "Cash for Scrap";
        }
        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            //this sets up a filter for if the items have been sold in the storeItemsListBox
            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemsListBox.DataSource = itemsBinding;

            cartBinding.DataSource = shoppingCartData;
            shoppingCartlistBox.DataSource = cartBinding;

            vendorBinding.DataSource = store.Vendors;
            vendorListBox.DataSource = vendorBinding;

            itemsListBox.DisplayMember = "Display";
            itemsListBox.ValueMember = "Display";

            shoppingCartlistBox.DisplayMember = "Display";
            shoppingCartlistBox.ValueMember = "Display";
            vendorListBox.DisplayMember = "Display";
            vendorListBox.ValueMember = "Display";

        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            //Figure out what is selected from the list of items
            //Copy that Item to the shooping Cart
            //Do we remove the Item from the list? no
            Item selectedItem = (Item)itemsListBox.SelectedItem;
            //MessageBox.Show("You Have Selected the following Item " + selectedItem.Title);
            shoppingCartData.Add(selectedItem);
            cartBinding.ResetBindings(false);
        }

        private void btnMakePurchase_Click(object sender, EventArgs e)
        {
            foreach(Item item in shoppingCartData)
            {
                item.Sold = true;
                item.Owner.PaymentDue += (decimal)item.Owner.Comission * item.Price;
            }
            shoppingCartData.Clear();

            itemsBinding.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            cartBinding.ResetBindings(false);
            itemsBinding.ResetBindings(false);

            vendorBinding.ResetBindings(false);
        }
    }
}

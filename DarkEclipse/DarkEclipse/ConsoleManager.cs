using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DarkEclipse;

public class ConsoleManager : BaseAdapter<string>
{
	List<string> ConsoleItems;
	Activity _activity;

	public ConsoleManager (Activity activity)
	{
		_activity = activity;
		FillContacts ();
	}

	public override int Count {
		get { return ConsoleItems.Count; }
	}

	public override Java.Lang.Object GetItem (int position)
	{
		return null;
	}

	public override long GetItemId (int position)
	{
		return ConsoleItems[position].Id;
	}

	public override View GetView (int position,
		View convertView, ViewGroup parent)
	{
		var view = convertView ?? _activity.LayoutInflater.Inflate
			(Resource.Layout.ListItem, parent, false);
		
		if (ConsoleItems [position].PhotoId == null) {
			contactImage = view.FindViewById<ImageView>
				(Resource.Id.imageView1);
			contactImage.SetImageResource
			(Resource.Drawable.Placeholder);
		} else {
			var contactUri = ContentUris.WithAppendedId
				(ContactsContract.Contacts.ContentUri,
					ConsoleItems [position].Id);
			var contactPhotoUri =
				Android.Net.Uri.WithAppendedPath(
					contactUri,
					ContactsContract.Contacts
					.Photo.ContentDirectory);
			contactImage.SetImageURI (contactPhotoUri);
		}
		return view;
	}

	void FillContacts ()
	{
		
	}
}

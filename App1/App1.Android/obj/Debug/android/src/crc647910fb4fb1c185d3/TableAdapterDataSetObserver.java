package crc647910fb4fb1c185d3;


public class TableAdapterDataSetObserver
	extends android.database.DataSetObserver
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChanged:()V:GetOnChangedHandler\n" +
			"n_onInvalidated:()V:GetOnInvalidatedHandler\n" +
			"";
		mono.android.Runtime.register ("Deloitte.Mobile.Cp3.Droid.Controls.TableView.TableAdapterDataSetObserver, App1.Android", TableAdapterDataSetObserver.class, __md_methods);
	}


	public TableAdapterDataSetObserver ()
	{
		super ();
		if (getClass () == TableAdapterDataSetObserver.class)
			mono.android.TypeManager.Activate ("Deloitte.Mobile.Cp3.Droid.Controls.TableView.TableAdapterDataSetObserver, App1.Android", "", this, new java.lang.Object[] {  });
	}


	public void onChanged ()
	{
		n_onChanged ();
	}

	private native void n_onChanged ();


	public void onInvalidated ()
	{
		n_onInvalidated ();
	}

	private native void n_onInvalidated ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

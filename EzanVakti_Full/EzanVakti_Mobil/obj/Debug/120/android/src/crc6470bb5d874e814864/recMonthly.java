package crc6470bb5d874e814864;


public class recMonthly
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("EzanVakti_Mobil.Resources.recMonthly, EzanVakti_Mobil", recMonthly.class, __md_methods);
	}


	public recMonthly (android.view.View p0)
	{
		super (p0);
		if (getClass () == recMonthly.class) {
			mono.android.TypeManager.Activate ("EzanVakti_Mobil.Resources.recMonthly, EzanVakti_Mobil", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
		}
	}

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

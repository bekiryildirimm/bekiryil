package crc6442453ce9e3b64c20;


public class BrowserActivity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("KıblePusulası_Mobil.BrowserActivity, KıblePusulası_Mobil", BrowserActivity.class, __md_methods);
	}


	public BrowserActivity ()
	{
		super ();
		if (getClass () == BrowserActivity.class) {
			mono.android.TypeManager.Activate ("KıblePusulası_Mobil.BrowserActivity, KıblePusulası_Mobil", "", this, new java.lang.Object[] {  });
		}
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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

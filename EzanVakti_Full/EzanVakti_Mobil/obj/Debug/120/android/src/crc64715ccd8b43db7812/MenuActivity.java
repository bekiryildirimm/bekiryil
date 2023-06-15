package crc64715ccd8b43db7812;


public class MenuActivity
	extends androidx.appcompat.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("EzanVakti_Mobil.MenuActivity, EzanVakti_Mobil", MenuActivity.class, __md_methods);
	}


	public MenuActivity ()
	{
		super ();
		if (getClass () == MenuActivity.class) {
			mono.android.TypeManager.Activate ("EzanVakti_Mobil.MenuActivity, EzanVakti_Mobil", "", this, new java.lang.Object[] {  });
		}
	}


	public MenuActivity (int p0)
	{
		super (p0);
		if (getClass () == MenuActivity.class) {
			mono.android.TypeManager.Activate ("EzanVakti_Mobil.MenuActivity, EzanVakti_Mobil", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
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

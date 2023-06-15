package crc64715ccd8b43db7812;


public class MyAlarmReceiver
	extends android.content.BroadcastReceiver
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onReceive:(Landroid/content/Context;Landroid/content/Intent;)V:GetOnReceive_Landroid_content_Context_Landroid_content_Intent_Handler\n" +
			"";
		mono.android.Runtime.register ("EzanVakti_Mobil.MyAlarmReceiver, EzanVakti_Mobil", MyAlarmReceiver.class, __md_methods);
	}


	public MyAlarmReceiver ()
	{
		super ();
		if (getClass () == MyAlarmReceiver.class) {
			mono.android.TypeManager.Activate ("EzanVakti_Mobil.MyAlarmReceiver, EzanVakti_Mobil", "", this, new java.lang.Object[] {  });
		}
	}


	public void onReceive (android.content.Context p0, android.content.Intent p1)
	{
		n_onReceive (p0, p1);
	}

	private native void n_onReceive (android.content.Context p0, android.content.Intent p1);

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

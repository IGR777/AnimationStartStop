using Android.App;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;
using Android.Support.Graphics.Drawable;
using Android.Runtime;
using Java.Lang;
using System;

namespace AnimationStartStop
{
	[Activity (Label = "AnimationStartStop", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;
		int _resource = 0;

		ImageView image;

		protected override void OnCreate (Bundle savedInstanceState) {
			base.OnCreate (savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);

			image = FindViewById<ImageView> (Resource.Id.myImage);
			//var a = AnimatedVectorDrawableCompat.Create (this, Resource.Drawable.anim_play_stop);
			//image.SetImageDrawable (a);
			//image.SetImageResource (Resource.Drawable.act_start_rotated);

			image.SetImageResource (Resource.Drawable.anim_play_stop);
			_resource = Resource.Drawable.anim_stop_play;

			//var a = AnimatedVectorDrawableCompat.Create (this, _resource);

			//ToggleResource ();


			button.Click += delegate {
				ToggleResource ();
				var anim = image.Drawable as AnimatedVectorDrawable;
				if (anim != null) {
					anim.Start ();
				}
			};
		}




		void ToggleResource () {
			if (_resource == Resource.Drawable.anim_stop_play)
				_resource = Resource.Drawable.anim_play_stop;
			else
				_resource = Resource.Drawable.anim_stop_play;


			image.SetImageResource (_resource);

		}
	}
}



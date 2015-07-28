using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.Support.V4.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace TabTest
{
    public class PageFragment : Fragment
    {
        public const string ArgPage = "Arg_Page";
        private int _page;

        public static PageFragment NewInstance(int page) {
            var args = new Bundle();
            args.PutInt(ArgPage, page);
            var fragment = new PageFragment();
            fragment.Arguments = args;
            return fragment;
        }

        public override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            _page = Arguments.GetInt(ArgPage);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState) {
            var view = (TextView)inflater.Inflate(Resource.Layout.fragment_page, container, false);
            view.Text = $"Fragment #{_page}";
            return view;
        }
    }
}
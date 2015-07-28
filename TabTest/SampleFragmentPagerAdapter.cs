using System.Collections.Generic;
using Android.Content;
using Android.Support.V4.App;
using Java.Lang;

namespace TabTest
{
    public class SampleFragmentPagerAdapter : FragmentPagerAdapter
    {
        private readonly Context _context;
        private List<string> _tabTitles;

        public SampleFragmentPagerAdapter(FragmentManager fm, Context context) : base(fm) {
            _context = context;
            _tabTitles = new List<string>() { "Tab1", "Tab2", "Tab3" };
        }
        public override int Count {
            get {
                return _tabTitles.Count;
            }
        }

        public override Fragment GetItem(int position) {
            return PageFragment.NewInstance(position + 1);
        }

        public override ICharSequence GetPageTitleFormatted(int position) {
            return new Java.Lang.String(_tabTitles[position]);
        }
    }
}
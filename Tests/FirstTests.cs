using System;
using NUnit.Framework;
using Library;
using Rhino.Mocks;

namespace Tests
{
	[TestFixture]
	public class FirstTests
	{
		public FirstTests ()
		{
		}
		
		[Test]
		public void CreateInstance ()
		{
			var first = new First ();
			Assert.That (first, Is.Not.Null);
		}
		
		[Test]
		public void CallAMethod ()
		{
			var first = new First ();
			Assert.That (first.Method (), Is.EqualTo ("base"));
		}
		
		[Test]
		public void FirstMock ()
		{
			var mocks = new MockRepository ();
			var first = mocks.DynamicMock<First> ();
			mocks.ReplayAll ();
			first.Expect (f => f.Method ()).Return ("hello");
			Assert.That (first.Method (), Is.EqualTo ("hello"));
			mocks.VerifyAll ();
		}
	}
}


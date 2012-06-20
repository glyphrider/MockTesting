using System;
using NUnit.Framework;
using Library;
using Rhino.Mocks;

namespace Tests
{
	[TestFixture]
	public class FirstTests
	{
		private First first;
		
		[SetUp]
		public void SetUp ()
		{
			first = new First ();
		}

		[Test]
		public void CreateInstance ()
		{
			Assert.That (first, Is.Not.Null);
		}

		[Test]
		public void CallAMethod ()
		{
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
		
		[Test]
		public void GetCollectionAndConfirmElementIsIncluded ()
		{
			Assert.That (first.Collection.Contains("test value"));
				
		}
	}
}


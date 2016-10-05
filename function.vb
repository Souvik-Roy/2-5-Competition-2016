'Calling a function without calling it
'cerner_2^5_2016

Imports System.Dynamic

Namespace ConsoleApplication1
	Class Program
		Private Shared Sub Main(args As String())
			Dim a As dynamic = New A()
			a.What()
			Console.ReadKey()
		End Sub

		Private Class A
			Inherits DynamicObject
			Public Overrides Function TryInvokeMember(binder As InvokeMemberBinder, args As [Object](), ByRef result As [Object]) As Boolean
				Console.WriteLine("First Hand Foundation !!")
				result = Nothing
				Return True
			End Function
		End Class
	End Class
End Namespace
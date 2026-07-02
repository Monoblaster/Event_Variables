expath("Event_Variables");
ex("replacers");
ex("outputs");
package evaluation
{
	function echoandreturn(%a)
	{
		echo(%a);
		return %a;
	}
	function evaluate(%a)
	{
		return echoandreturn(VCE_ReplacerDoEvaluate(echoandreturn(%a)));
	}

	function Test1()
	{
		return evaluate("1+1") == 2;
	}

	function Test2()
	{
		return evaluate("(1-(0/524288))*8") == 8;
	}

	function Test3()
	{
		return evaluate("(0.5-(0/524288)+0)*16") == 8;
	}

	function Test4()
	{
		return evaluate("1.00e+5-1") == 99999;
	}
};

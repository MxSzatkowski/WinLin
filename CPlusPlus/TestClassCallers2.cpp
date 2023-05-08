


#ifdef _WIN32
#include "TestClassCallers2.h"
#elif __linux__
#include "Ent.h"
#endif

extern "C"
{

	Ent* CreateTestClass()
	{
		return new Ent();
	}

	void DisposeTestClass(Ent* pObject)
	{

		delete pObject;

	}

	float CallAdd(Ent* pObject, float a, float b)
	{
		return pObject->Add(a, b);

	}

}
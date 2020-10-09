CSCC := mcs
CSCCFLAGS := -unsafe
ARTEFACTS := HelloWorld Rectangle Sizeof DataTypes SwapDemo TypeConversions Variables ConstantsAndLiterals Operators \
			 DecisionMaking Loops Primes Encapsulation Methods PassByValue PassByReference OutParameters Nullables Arrays \
			 ArrayMethods Varargs Matrix Strings Structures Enums Classes Inheritance Interfaces Polymorphism OperatorOverloading \


.PHONY: all run clean 

all : $(ARTEFACTS)

$(ARTEFACTS): %: %.cs
	$(CSCC) $(CSCCFLAGS) -out:$@ $<

clean:
	rm -f $(ARTEFACTS)	*.exe
CSCC := mcs
CSCCFLAGS := -unsafe
ARTEFACTS := HelloWorld Rectangle Sizeof DataTypes SwapDemo TypeConversions Variables ConstantsAndLiterals Operators \
			 DecisionMaking

.PHONY: all run clean 

all : $(ARTEFACTS)

$(ARTEFACTS): %: %.cs
	$(CSCC) $(CSCCFLAGS) -out:$@ $<

clean:
	rm -f $(ARTEFACTS)	*.exe
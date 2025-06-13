# Minneshantering

Frågor:
*1. Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion*
Stacken fungerar som en container där man kan interagera med objektet som senast sattes in på stacken. Ett exempel är att se det som en hög med böcker staplade på varandra. Du måste ta bort den översta boken för att komma åt den som är under den osv.

Stacken har koll på vilka anrop och metoder som körs, när metoden är körd kastas den från stacken och nästa körs. Stacken är alltså självunderhållande och behöver ingen hjälp med minnet. 

Heapen är en slags container där allt är tillgängligt hela tiden, det går snabbt att nå det minnet man behöverså länge vi vet vad vi söker efter.
Heapen håller stor del av informationen (men inte har någon koll på exekveringsordning) behöver oroa sig för Garbage Collection. 

*3. Vad är Value Types respektive Reference Types och vad skiljer dem åt?*
Value Types är typer från System.ValueType som listas nedan:

• bool

• byte

• char

• decimal 

• double

• enum 

• float 

• int

• long 

• sbyte

• short 

• struct 

• uint

• ulong 

• ushort

Reference Types är typer som ärver från System.Object (eller är System.Object.object) 

• class

• interface 

• object

• delegate 

• string

Reference type lagras alltid på heapen. Value types lagras där de deklareras; på stacken eller heapen. 

*4. Följande metoder [img in original PDF] genererar olika svar. Den första returnerar 3, den
andra returnerar 4, varför?*

Den första metoden använder sig av värden som sparas på heapen medans den andra på stacken.


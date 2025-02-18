namespace CSAdvancedProg15_AccessModifiers;

class Program
{
    static void Main(string[] args)
    {
        //Access modifiers
        
        //Access modifiers are utilized based on usage scope principle;
        //In short, We give members access modifiers that allows them to be used merely where we will use them towards their purposes.
        
        //Public
        //To make whatever it is declared to accessible from everywhere, every project encompassed within the solution.
        
        
        //Private
        //To make the marked member only accessible within the scopes of architectures (such as classes, structures, interfaces, etc.)..
        //..where the relevant member is declared.
        //private is the default access modifier set to any members if the modifier is not specified.
        
        
        //Protected
        //To make the member accessible within the class where it is declared and the ones below it in the waterfall in the inheritance hierarchy.
        //If a class in a different project under the same solution is inheriting the class where the protected member is declared..
        //..it is still accessible, so it totally depends on the inheritence and that the solutions the projects are declared under the same.
        //There is an important particular feature being brought along with the protected keyword tho, which is that the protected members..
        //can't be accessible over instances of the classes they are accessible in as if they are marked with static keyword too.
        
        
        //Internal
        //To make the member accessible only within the project where it is declared.
        
        
        //Protected Internal
        //To make the member accessible through instances (This feature is steming from internal) and from
        //..all classes in the same project although it has the protected keyword, and in the..
        //..class where it is declared, and the ones below it in the waterfall in the inheritance hierarchy (this one is coming from protected)..
        //.. although those classes are declared in a different project under the same solution.
        //In short, For it to be accessible from the classes declared in a different project, those classes should have inheritanceship with..
        //the class where the member is declared (This part is kinda from the protected's effect) and this member is accessible from..
        //..any classes declared within the same project (And this one is from the internal's effect).
        
        
        //Private Protected
        //Protected alone makes it possible to access the member from classes declared in a different project if those classes inherit the class..
        //.. where the member is declared.
        //When it is private protected, the access possibility above is not available anymore, the marked member becomes only accessible within..
        //.. within the classes in the same project with the base class.
        
    }
}
# Boxing in C#

## Definition
Boxing is the process of converting a value type to a reference type (`object`).

## Example

```csharp
int valType = 10;
object objType = valType;
```

## Output

```
Value Type : 10
Object Type: 10
Value Type Data Type : System.Int32
Object Type Data Type: System.Int32
```

## Notes
- Boxing happens implicitly.
- The value is copied into an object.
- Boxing allocates memory on the heap, so excessive boxing may affect performance.
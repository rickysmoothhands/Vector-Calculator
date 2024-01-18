# Vector Calculator - Handout

### Points
150 (+50 pt. Extra Credit Opportunity)

---

### Due Date
???? ??th, 2024

---

### Goal
To create a C# class capable of representing Vectors and performing the Vector operations that we learn about in class.

---
### Instructions
Start by creating a C# class that represents a 3D Vector. This must have an X, a Y, and a Z (think about what data type best represents these: An int? A float? A string? A bool? Could you use an array for this?). After you do this, you must create a constructor that creates a Vector given the values. Then, you must override the ToString() method to allow the user to print the Vector using the format “[x, y, z]”. After you confirm that this works, create methods for each of the math concepts we learned in class. The following are cases you must make methods for (the grading/milestones). There are a total of 12 methods you need to implement. If at any point you need help, please ask another student before asking me. Finally, each function must have comments explaining what's going on, as well as an example of the math concept in play.

---

### Grading Rubric - Learning Targets & Success Criteria
Your grade will be determined based on how well your code passes a number of tests. Each test that it passes is worth 2 points, with each test falling under a different category of Learning Targets for the given unit. There will be 5 tests per function, so expect negative numbers and decimals too, not just positive integers. You may test your code any number of times before submission to figure out what you need to improve on before the project is due. Learning Targets are split into 2 categories, Mastery Goals and Stretch Goals. Once you have completed all the Mastery Goals, you are expected to work on the Stretch Goals. Stretch Goals are worth extra credit points.

#### [150 pts.] Mastery Goals
- Recognize vector quantities as having both magnitude and direction. Represent vector quantities by directed line segments, and use appropriate symbols for vectors and their magnitudes (e.g., v, |v|, ||v||, v).
    - [10] XYFormToMagnitudeDirectionForm
    - [10] MagnitudeDirectionFormToXYForm
- Find the components of a vector by subtracting the coordinates of an initial point from the coordinates of a terminal point.
    - [10] 
    - [10] 
- Solve problems involving velocity and other quantities that can be represented by vectors.
    - [10] 
    - [10] 
- Add vectors end-to-end, component-wise, and by the parallelogram rule. Understand that the magnitude of a sum of two vectors is typically not the sum of the magnitudes.
    - [10] Addition
    - [10] 
- Given two vectors in magnitude and direction form, determine the magnitude and direction of their sum.
    - [10] 
- Understand vector subtraction v – w as v + (–w), where –w is the additive inverse of w, with the same magnitude as w and pointing in the opposite direction. Represent vector subtraction graphically by connecting the tips in the appropriate order, and perform vector subtraction component-wise.
    - [10] Negation
    - [10] Subtraction
- Represent scalar multiplication graphically by scaling vectors and possibly reversing their direction; perform scalar multiplication component-wise, e.g., as c(vx, vy) = (cvx, cvy).
    - [10] Scaling
- Compute the magnitude of a scalar multiple cv using ||cv|| = |c|v. Compute the direction of cv knowing that when |c|v ≠ 0, the direction of cv is either along v (for c > 0) or against v (for c < 0).

#### [+50 pts.] Stretch Goals
- [+10] Use of proper keywords and accessibility modifiers (readonly, const, public, private, etc.)
- [+10] Null Checking or use of structs to avoid null possibility.
- [+10] Use of properties to make retrieving values easier.
- [+10] Support for any sized Vector (2D, 3D, 4D, etc.)
- [+10] Operator overrides for Add, Invert, Subtract, Scale, and Equals
- 
---


- [10] Magnitude
- [10] Normalization
- [10] Dot Product
- [10] Cross Product
- [10] Angle Between
- [10] Projection
- [10] Reflection
- [10] Equals

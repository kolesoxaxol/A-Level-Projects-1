using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyClass
{
    
    public static class Dean
    {
        private static Random rndStudents = new Random();

        private static int _assistantProfessorLimit = 20;
        private static int _teacherLimit = 15;
        private static int _teachingAssistant = 5;
        private static int _randomStudents;  // че _randomStudents с подчеркивания а остальные нет? в чем ее особенность?
                                                // Ответ: private поля с _ следует указывать, исправил.

        public static void SortUniver()
        {
            Teacher[] teachers = UniverBase.GetTeachers;
            List<Student> students = UniverBase.GetStudents;
            Group[] groups = UniverBase.GetGroups;

            for (int i=0; i < groups.Length; i++)
            {
                int limitStudents = 0;
                Group newGroup = new Group();
                    newGroup.GroupName = groups[i].GroupName;

                Teacher newTeacher = teachers[i];
                    newGroup.TeacherName = newTeacher.TeacherName;
                    newGroup.TeacherType = newTeacher.TeacherType;

                int sudentsCount = students.Count;

                for (int s = 0; s < sudentsCount; s++)
                {
                    
                    //я бы переделал это на switch и для TeacherType использовал Enum
                        // для себя попробую
                    // 20, 15, 5 это магические числа должны быть где то в сеттингах иди просто в переменых с самодокументируемым названием.
                        // Не понял
                    
                    if (newTeacher.TeacherType == "Professor Assistant" && limitStudents >= 20)
                    {
                        Console.WriteLine($"Professor Assistant: не может принять больше {_assistantProfessorLimit} студентов");
                        break;
                    }
                    else if (newTeacher.TeacherType == "Teacher" && limitStudents >= 15)
                    {
                        Console.WriteLine($"Teacher: не может принять больше {_teacherLimit} студентов");
                        break;
                    }
                    else if (newTeacher.TeacherType == "Teaching Assistant" && limitStudents >= 5)
                    {
                        Console.WriteLine($"Teaching Assistant: не может принять больше {_teachingAssistant} студентов");
                        break;
                    }

                    // а что ты делаешь в строчках ниже ?
                        // Ответ: Случайно выбираю студента из списка, а не по порядку. Затем удаляю из общего списка этих студентов, чтобы они не повторялись.

                    _randomStudents = rndStudents.Next(0, UniverBase.GetStudentsCount());
                    Student newStudent = students[_randomStudents];
                    students.RemoveAt(_randomStudents);

                    newGroup.AddStudentToGroup(newStudent);
                    limitStudents++;
                }

                UniverBase.AddWholeGroup(newGroup);

                Console.WriteLine($"Группа: \"{newGroup.GroupName}\" c преподователем \"{newGroup.TeacherName}\" приняла {newGroup.GetCountStudents()} студентов.");
                
                // почему ты решил использовать new string ? 
                    // удобнее, чем писать 50 дефисов
                Console.WriteLine(new string('-', 50));
            }

            Console.WriteLine($"Университет был переполнен и не смог добрать {students.Count} студентов");
            Console.WriteLine(new string('-', 50));
        }
    }
}

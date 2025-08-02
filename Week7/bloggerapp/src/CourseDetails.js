import React from 'react';

function CourseDetails() {
  const courses = [
    { title: "Angular", date: "4/5/2021" },
    { title: "React", date: "6/3/2021" },
  ];

  return (
    <div style={{ textAlign: 'left', padding: '10px' }}>
      <h2>Course Details</h2>
      {courses.map((course, index) => (
        <div key={index} style={{ marginBottom: '10px' }}>
          <strong>{course.title}</strong><br />
          {course.date}
        </div>
      ))}
    </div>
  );
}

export default CourseDetails;

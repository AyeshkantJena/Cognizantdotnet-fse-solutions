import React from 'react';
import CohortDetails from './CohortDetails';
import { CohortsData } from './Cohort';

function App() {
  return (
    <div>
      <h2>Cohort Dashboard</h2>

      {CohortsData.map((cohort, index) => (
        <CohortDetails
          key={index}
          name={cohort.cohortCode}
          startDate={cohort.startDate}
          trainer={cohort.trainerName}
          coach={cohort.coachName}
          status={cohort.currentStatus}
        />
      ))}
    </div>
  );
}

export default App;


// import React from 'react';
// import CohortDetails from './CohortDetails';

// function App() {
//   return (
//     <div>
//       <h2>Cohort Dashboard</h2>

//       <CohortDetails name="React Basics" status="ongoing" />
//       <CohortDetails name="Advanced React" status="upcoming" />
//       <CohortDetails name="JavaScript Essentials" status="ongoing" />
//       <CohortDetails name="UI/UX Workshop" status="completed" />

//     </div>
//   );
// }

// export default App;

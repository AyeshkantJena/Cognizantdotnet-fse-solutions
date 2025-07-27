import React from 'react';
import styles from './CohortDetails.module.css';

function CohortDetails({ name, startDate, trainer, coach, status }) {
  const titleStyle = {
    color: status.toLowerCase() === 'ongoing' ? 'green' : 'blue'
  };

  return (
    <div className={styles.box}>
      <h3 style={titleStyle}>{name}</h3>
      <dl>
        <dt>Started On:</dt>
        <dd>{startDate}</dd>

        <dt>Trainer:</dt>
        <dd>{trainer}</dd>

        <dt>Coach:</dt>
        <dd>{coach}</dd>

        <dt>Status:</dt>
        <dd>{status}</dd>
      </dl>
    </div>
  );
}

export default CohortDetails;


// import React from 'react';
// import styles from './CohortDetails.module.css';

// function CohortDetails({ status, name }) {
//   const titleStyle = {
//     color: status === 'ongoing' ? 'green' : 'blue'
//   };

//   return (
//     <div className={styles.box}>
//       <h3 style={titleStyle}>{name}</h3>
//       <dl>
//         <dt>Status:</dt>
//         <dd>{status}</dd>
//       </dl>
//     </div>
//   );
// }

// export default CohortDetails;

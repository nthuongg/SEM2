<?php $__env->startSection('content'); ?>

<div class="card">
	<div class="card-header">Edit Student</div>
	<div class="card-body">
		<form method="post" action="<?php echo e(route('students.update', $student->id)); ?>" enctype="multipart/form-data">
			<?php echo csrf_field(); ?>
			<?php echo method_field('PUT'); ?>
			<div class="row mb-3">
				<label class="col-sm-2 col-label-form">Student Name</label>
				<div class="col-sm-10">
					<input type="text" name="student_name" class="form-control" value="<?php echo e($student->student_name); ?>" />
				</div>
			</div>
			<div class="row mb-3">
				<label class="col-sm-2 col-label-form">Student Email</label>
				<div class="col-sm-10">
					<input type="text" name="student_email" class="form-control" value="<?php echo e($student->student_email); ?>" />
				</div>
			</div>
			<div class="row mb-4">
				<label class="col-sm-2 col-label-form">Student Gender</label>
				<div class="col-sm-10">
					<select name="student_gender" class="form-control">
						<option value="Male">Male</option>
						<option value="Female">Female</option>
					</select>
				</div>
			</div>
			<div class="row mb-4">
				<label class="col-sm-2 col-label-form">Student Image</label>
				<div class="col-sm-10">
					<input type="file" name="student_image" />
					<br />
					<img src="<?php echo e(asset('images/' . $student->student_image)); ?>" width="100" class="img-thumbnail" />
					<input type="hidden" name="hidden_student_image" value="<?php echo e($student->student_image); ?>" />
				</div>
			</div>
			<div class="text-center">
				<input type="hidden" name="hidden_id" value="<?php echo e($student->id); ?>" />
				<input type="submit" class="btn btn-primary" value="Edit" />
			</div>
		</form>
	</div>
</div>
<script>
document.getElementsByName('student_gender')[0].value = "<?php echo e($student->student_gender); ?>";
</script>

<?php $__env->stopSection(); ?>

<?php echo $__env->make('master', \Illuminate\Support\Arr::except(get_defined_vars(), ['__data', '__path']))->render(); ?><?php /**PATH D:\SEM2\PHP\Class5\myfirstapp\resources\views/edit.blade.php ENDPATH**/ ?>